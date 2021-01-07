using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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

            TextBoxAmplada.Text=clConfiguracio.Caracteristiques["amplada"];
            TextBoxAltura.Text=clConfiguracio.Caracteristiques["altura"];
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                clConfiguracio.Caracteristiques["amplada"]=TextBoxAmplada.Text;
                clConfiguracio.Caracteristiques["altura"]=TextBoxAltura.Text;
                clConfiguracio.Save();
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private bool ValidateForm()
        {
            bool validated = true;

            string pattern = @"^([0-9]{1,3}|1000)$"; // Máximo 1000
            string message = "El format del camps només permet valors des del 0 fins el 1000.";
            Regex reg = new Regex(pattern);

            if(!reg.IsMatch(TextBoxAmplada.Text))
            {
                MessageBox.Show(message);
                TextBoxAmplada.Focus();
                
                validated=false;
            }
            else if(!reg.IsMatch(TextBoxAltura.Text))
            {
                MessageBox.Show(message);
                TextBoxAltura.Focus();

                validated=false;
            }

            return validated;
        }
    }
}
