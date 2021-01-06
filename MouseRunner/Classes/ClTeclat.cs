using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MouseRunner.Classes
{
    // Un Hook és una eina que ens permet "enganxar-nos" als missatges que, a baix nivell, s'intercanvien els elements del sistema operatiu
    // El que fa el hook és interceptar el missatge abans que arribi al destinatari
    // En aquest cas utilitzarem els hooks del teclat
    //
    // Referència :  https://docs.microsoft.com/en-us/windows/win32/winmsg/about-hooks
    //
    public class ClTeclat
    {
        //
        //  *** FEM MOLTES DECLARACIONS AMB static PER A PODER TREBALLAR SENSE NECESSITAT DE CREAR UNA INSTÀNCIA DE LA CLASSE
        //  
        private const int WH_KEYBOARD_LL = 13;      // WH_KEYBOARD_LL (13) identifica el hook que intercepta les entrades per teclat    
        private const int WM_KEYDOWN = 0x0100;      // WM_KEYDOWN (0x0100) identifica el missatge enviat quan es produeix un KeyDown
                                                    // Fixa't que el prefix WH vol dir Windows Hook i WM vol dir Windows Message

        // LowLevelKeyboardProc és la rutina (el codi) que gestiona el teclat a baix nivell, treballa de manera asíncrona amb callback
        // En la línia següent li estem assignant un punter (C language nightmare jejeje) indicant que el sistema ha d'executar la nostra
        // rutina, la que hem anomenat CallbackTeclat
        //
        // El delegate és un instrument de .NET que ens permet gestionar les crides asíncrones i la comunicació entre processos i subprocessos
        private static LowLevelKeyboardProc _proc = CallbackTeclat;
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr _hookID = IntPtr.Zero;            // reservem un lloc a memòria per a posar-hi l'id del Hook

        public static event EventHandler<Char> haArribatUnaTecla;   // utilitzarem un event per a informar al Form que s'ha premut una tecla
                                                                    // aquest event retornarà un paràmetre que és el char de la tecla premnuda
        public static void IniciarHook()
        {
            _hookID=ActivarHook(_proc);
        }

        private static IntPtr ActivarHook(LowLevelKeyboardProc proc)
        {
            Process curProcess = Process.GetCurrentProcess();
            ProcessModule curModule = curProcess.MainModule;

            // SetWindowsHookEx és la funció que incorpora el hook al sistema. És com si poséssim un listener o sniffer que vagi interceptant els missatges 
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
        }

        public static void TancarHook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr CallbackTeclat(int nCode, IntPtr wParam, IntPtr lParam)
        {
            // si som aquí es perquè el teclat ha enviat un missatge de baix nivell
            if(nCode>=0 && wParam==(IntPtr)WM_KEYDOWN)
            {
                // si som aquí és perquè el missatge és de KeyDown
                int teclaPremuda = Marshal.ReadInt32(lParam);       // Marshal és una llibreria de rutines que permeten treballar a baix nivell amb la memòria
                                                                    // en aquest cas llegim la posició de memòria on hi ha el char de la tecla premuda

                haArribatUnaTecla(null, (Char)teclaPremuda);       // disparem l'event per a que el Form sàpiga que s'ha premut una tecla i li passem la tecla que és
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        // Aquestes declaracions són les de les llibreries externes DLL de Windows que contenen l'API
        // Utilitzem user32.dll i kernel32.dll
        // De user32.dll fem servir la funció SetWindowsHookEx, UnhookWindowsHookEx, CallNextHookEx
        // De kernel32.dll fem serrvir GetModuleHandle

        // SetWindowsHookEx
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        // UnhookWindowsHookEx
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        // CallNextHookEx
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        // GetModuleHandle
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
