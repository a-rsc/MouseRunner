
namespace MouseRunner
{
    partial class FrmConfiguracio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracio));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelAltura = new System.Windows.Forms.Label();
            this.TextBoxAltura = new System.Windows.Forms.TextBox();
            this.LabelAmplada = new System.Windows.Forms.Label();
            this.TextBoxAmplada = new System.Windows.Forms.TextBox();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.CausesValidation = false;
            this.GroupBox1.Controls.Add(this.LabelAltura);
            this.GroupBox1.Controls.Add(this.TextBoxAltura);
            this.GroupBox1.Controls.Add(this.LabelAmplada);
            this.GroupBox1.Controls.Add(this.TextBoxAmplada);
            this.GroupBox1.Location = new System.Drawing.Point(10, 10);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.GroupBox1.Size = new System.Drawing.Size(360, 95);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Configuració";
            // 
            // LabelAltura
            // 
            this.LabelAltura.CausesValidation = false;
            this.LabelAltura.Location = new System.Drawing.Point(10, 60);
            this.LabelAltura.Margin = new System.Windows.Forms.Padding(3);
            this.LabelAltura.Name = "LabelAltura";
            this.LabelAltura.Padding = new System.Windows.Forms.Padding(3);
            this.LabelAltura.Size = new System.Drawing.Size(134, 20);
            this.LabelAltura.TabIndex = 0;
            this.LabelAltura.Text = "Altura (cm)";
            this.LabelAltura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxAltura
            // 
            this.TextBoxAltura.BackColor = System.Drawing.Color.White;
            this.TextBoxAltura.CausesValidation = false;
            this.TextBoxAltura.Location = new System.Drawing.Point(150, 60);
            this.TextBoxAltura.Name = "TextBoxAltura";
            this.TextBoxAltura.ShortcutsEnabled = false;
            this.TextBoxAltura.Size = new System.Drawing.Size(80, 20);
            this.TextBoxAltura.TabIndex = 2;
            this.TextBoxAltura.Text = "0";
            this.TextBoxAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelAmplada
            // 
            this.LabelAmplada.CausesValidation = false;
            this.LabelAmplada.Location = new System.Drawing.Point(10, 20);
            this.LabelAmplada.Margin = new System.Windows.Forms.Padding(3);
            this.LabelAmplada.Name = "LabelAmplada";
            this.LabelAmplada.Padding = new System.Windows.Forms.Padding(3);
            this.LabelAmplada.Size = new System.Drawing.Size(134, 20);
            this.LabelAmplada.TabIndex = 0;
            this.LabelAmplada.Text = "Amplada (cm)";
            this.LabelAmplada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxAmplada
            // 
            this.TextBoxAmplada.BackColor = System.Drawing.Color.White;
            this.TextBoxAmplada.CausesValidation = false;
            this.TextBoxAmplada.Location = new System.Drawing.Point(150, 20);
            this.TextBoxAmplada.Name = "TextBoxAmplada";
            this.TextBoxAmplada.ShortcutsEnabled = false;
            this.TextBoxAmplada.Size = new System.Drawing.Size(80, 20);
            this.TextBoxAmplada.TabIndex = 1;
            this.TextBoxAmplada.Text = "0";
            this.TextBoxAmplada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Location = new System.Drawing.Point(10, 120);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(150, 25);
            this.ButtonAccept.TabIndex = 3;
            this.ButtonAccept.Text = "&Acceptar";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(220, 120);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(150, 25);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "&Cancel·lar";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FrmConfiguracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConfiguracio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuració - MouseRunner";
            this.TopMost = true;
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label LabelAltura;
        private System.Windows.Forms.TextBox TextBoxAltura;
        private System.Windows.Forms.Label LabelAmplada;
        private System.Windows.Forms.TextBox TextBoxAmplada;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
    }
}