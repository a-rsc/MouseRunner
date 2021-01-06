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
    public partial class FrmConfiguracio : Form
    {
        // XML
        private ClConfiguracio clConfiguracio;

        public FrmConfiguracio(ClConfiguracio clConfiguracio)
        {
            InitializeComponent();

            this.clConfiguracio=clConfiguracio;

            TextBoxAmplada.Text=clConfiguracio.Amplada;
            TextBoxAltura.Text=clConfiguracio.Altura;
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            clConfiguracio.Amplada = TextBoxAmplada.Text;
            clConfiguracio.Altura=TextBoxAltura.Text;
            clConfiguracio.Save();
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
