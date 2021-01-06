using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseRunner.Classes;

namespace MouseRunner
{
    public partial class FrmMostrarDades : Form
    {
        private bool allowVisible=false;     // ContextMenu's Show command used
        private bool allowClose=false;       // ContextMenu's Exit command used

        // XML
        private ClConfiguracio clConfiguracio;
        private ClDades clDades;

        // Mouse
        private ClApi posMouse;

        private readonly int screenWidthPixels = Screen.PrimaryScreen.Bounds.Width;
        private readonly int screenHeightPixels = Screen.PrimaryScreen.Bounds.Height;

        public FrmMostrarDades()
        {
            InitializeComponent();

            // XML
            clConfiguracio = new ClConfiguracio();
            clDades = new ClDades();

            TextBoxM.Text=clDades.Metres;
            TextBoxA.Text=clDades.NumA;
            TextBoxE.Text=clDades.NumE;
            TextBoxI.Text=clDades.NumI;
            TextBoxO.Text=clDades.NumO;
            TextBoxU.Text=clDades.NumU;

            // Mouse
            posMouse=new ClApi();

            // Teclat
            ClTeclat.IniciarHook();
            ClTeclat.haArribatUnaTecla+=new EventHandler<Char>(mostrarVocal);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Mouse
            TmMouse.Start();
        }

        protected override void SetVisibleCore(bool value)
        {
            Debug.WriteLine("------------------ SetVisibleCore");
            if(!allowVisible)
            {
                value=false;
                if(!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Debug.WriteLine("OnFormClosing");
            if(!allowClose)
            {
                Hide();
                e.Cancel=true;
            }
            ClTeclat.TancarHook();
            base.OnFormClosing(e);
        }

        private void FrmMostrarDades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("FrmMostrarDades_FormClosed");
        }

        private void mostrarDades_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("mostrarDades_Click");
            allowVisible=true;
            SetVisibleCore(allowVisible);
            WindowState=FormWindowState.Normal;
            // Show();
            BringToFront();
            Focus();
        }

        private void Configuracio_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Configuracio_Click");
            FrmConfiguracio configuracio = new FrmConfiguracio(clConfiguracio);
            if(WindowState!=FormWindowState.Minimized && allowVisible)
            {
                allowVisible=false;
                SetVisibleCore(allowVisible);
            }
            configuracio.Show();
        }

        private void Sortir_Click(object sender, EventArgs e)
        {
            allowClose=true;
            clDades.Metres=TextBoxM.Text;
            clDades.NumA=TextBoxA.Text;
            clDades.NumE=TextBoxE.Text;
            clDades.NumI=TextBoxI.Text;
            clDades.NumO=TextBoxO.Text;
            clDades.NumU=TextBoxU.Text;
            clDades.Save();
            Application.Exit();
        }

        private void FrmMostrarDades_Resize(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Minimized && allowVisible)
            {
                Debug.WriteLine("minimize");
                allowVisible=false;
                SetVisibleCore(allowVisible);
            }
        }

        private void ButtonHide_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
            FrmMostrarDades_Resize(sender, e);
        }

        private void mostrarVocal(object sender, Char ch)
        {
            switch(ch)
            {
                case 'A':
                    TextBoxA.Text=(Int32.Parse(TextBoxA.Text)+1).ToString();
                    break;
                case 'E':
                    TextBoxE.Text=(Int32.Parse(TextBoxE.Text)+1).ToString();
                    break;
                case 'I':
                    TextBoxI.Text=(Int32.Parse(TextBoxI.Text)+1).ToString();
                    break;
                case 'O':
                    TextBoxO.Text=(Int32.Parse(TextBoxO.Text)+1).ToString();
                    break;
                case 'U':
                    TextBoxU.Text=(Int32.Parse(TextBoxU.Text)+1).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case "ButtonM":
                    TextBoxM.Text="0";
                    break;
                case "ButtonA":
                    TextBoxA.Text="0";
                    break;
                case "ButtonE":
                    TextBoxE.Text="0";
                    break;
                case "ButtonI":
                    TextBoxI.Text="0";
                    break;
                case "ButtonO":
                    TextBoxO.Text="0";
                    break;
                case "ButtonU":
                    TextBoxU.Text="0";
                    break;
                default:
                    break;
            }
        }

        private void tmMouse_Tick(object sender, EventArgs e)
        {
            ClApi posMouseNext = new ClApi();

            double longitud = Double.Parse(TextBoxM.Text);
            double incrementX, incrementY;
            double screenWidthCm = Double.Parse(clConfiguracio.Amplada);
            double screenHeightCm = Double.Parse(clConfiguracio.Altura);

            if(ClApi.GetCursorPos(ref posMouseNext.point))
            {
                incrementX = Math.Abs(posMouseNext.point.X - posMouse.point.X)*(screenWidthCm/screenWidthPixels)/100; // m
                incrementY = Math.Abs(posMouseNext.point.Y - posMouse.point.Y)*(screenHeightCm/screenHeightPixels)/100; // m

                longitud+=Math.Sqrt(Math.Pow(incrementX, 2)+Math.Pow(incrementY, 2));

                TextBoxM.Text=Math.Round(longitud, 2).ToString();
                //Debug.WriteLine(TextBoxM.Text);

                posMouse=posMouseNext;
            }
            else
            {
                TextBoxM.Text=ClApi.GetLastError().ToString();
            }
        }
    }
}
