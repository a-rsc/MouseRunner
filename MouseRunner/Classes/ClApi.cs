using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MouseRunner.Classes
{
    class ClApi
    {
        public Point point = new Point();

        // obtenim la posició del cursor
        // La ruta esta inclosa al path -> Windows\System32\user32.dll
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref Point lpPoint);

        // obtenir el darrer error 
        // La ruta esta inclosa al path -> Windows\System32\user32.dll
        [DllImport("user32.dll")]
        public static extern long GetLastError();

    }
}
