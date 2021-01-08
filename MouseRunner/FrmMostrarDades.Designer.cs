
namespace MouseRunner
{
    partial class FrmMostrarDades
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarDades));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonM = new System.Windows.Forms.Button();
            this.LabelM = new System.Windows.Forms.Label();
            this.TextBoxM = new System.Windows.Forms.TextBox();
            this.ButtonHide = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonA = new System.Windows.Forms.Button();
            this.ButtonE = new System.Windows.Forms.Button();
            this.ButtonI = new System.Windows.Forms.Button();
            this.ButtonO = new System.Windows.Forms.Button();
            this.ButtonU = new System.Windows.Forms.Button();
            this.LabelU = new System.Windows.Forms.Label();
            this.TextBoxU = new System.Windows.Forms.TextBox();
            this.LabelO = new System.Windows.Forms.Label();
            this.TextBoxO = new System.Windows.Forms.TextBox();
            this.LabelI = new System.Windows.Forms.Label();
            this.TextBoxI = new System.Windows.Forms.TextBox();
            this.LabelE = new System.Windows.Forms.Label();
            this.TextBoxE = new System.Windows.Forms.TextBox();
            this.LabelA = new System.Windows.Forms.Label();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MostrarDades = new System.Windows.Forms.ToolStripMenuItem();
            this.Configuracio = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Sortir = new System.Windows.Forms.ToolStripMenuItem();
            this.TmMouse = new System.Windows.Forms.Timer(this.components);
            this.TmTeclat = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.CausesValidation = false;
            this.GroupBox1.Controls.Add(this.ButtonM);
            this.GroupBox1.Controls.Add(this.LabelM);
            this.GroupBox1.Controls.Add(this.TextBoxM);
            this.GroupBox1.Location = new System.Drawing.Point(10, 10);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.GroupBox1.Size = new System.Drawing.Size(360, 50);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Mouse";
            // 
            // ButtonM
            // 
            this.ButtonM.BackgroundImage = global::MouseRunner.Properties.Resources.Roadrunner;
            this.ButtonM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonM.FlatAppearance.BorderSize = 0;
            this.ButtonM.Location = new System.Drawing.Point(250, 20);
            this.ButtonM.Name = "ButtonM";
            this.ButtonM.Size = new System.Drawing.Size(20, 20);
            this.ButtonM.TabIndex = 1;
            this.ButtonM.UseVisualStyleBackColor = false;
            this.ButtonM.Click += new System.EventHandler(this.button_Click);
            // 
            // LabelM
            // 
            this.LabelM.CausesValidation = false;
            this.LabelM.Location = new System.Drawing.Point(10, 20);
            this.LabelM.Margin = new System.Windows.Forms.Padding(3);
            this.LabelM.Name = "LabelM";
            this.LabelM.Padding = new System.Windows.Forms.Padding(3);
            this.LabelM.Size = new System.Drawing.Size(120, 20);
            this.LabelM.TabIndex = 0;
            this.LabelM.Text = "Metres recorreguts";
            this.LabelM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxM
            // 
            this.TextBoxM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxM.CausesValidation = false;
            this.TextBoxM.Enabled = false;
            this.TextBoxM.Location = new System.Drawing.Point(150, 20);
            this.TextBoxM.Name = "TextBoxM";
            this.TextBoxM.ShortcutsEnabled = false;
            this.TextBoxM.Size = new System.Drawing.Size(80, 20);
            this.TextBoxM.TabIndex = 0;
            this.TextBoxM.TabStop = false;
            this.TextBoxM.Text = "0";
            this.TextBoxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonHide
            // 
            this.ButtonHide.AccessibleName = "";
            this.ButtonHide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHide.Location = new System.Drawing.Point(10, 310);
            this.ButtonHide.Name = "ButtonHide";
            this.ButtonHide.Size = new System.Drawing.Size(360, 30);
            this.ButtonHide.TabIndex = 7;
            this.ButtonHide.Text = "Amagar";
            this.ButtonHide.UseVisualStyleBackColor = false;
            this.ButtonHide.Click += new System.EventHandler(this.ButtonHide_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.CausesValidation = false;
            this.GroupBox2.Controls.Add(this.ButtonA);
            this.GroupBox2.Controls.Add(this.ButtonE);
            this.GroupBox2.Controls.Add(this.ButtonI);
            this.GroupBox2.Controls.Add(this.ButtonO);
            this.GroupBox2.Controls.Add(this.ButtonU);
            this.GroupBox2.Controls.Add(this.LabelU);
            this.GroupBox2.Controls.Add(this.TextBoxU);
            this.GroupBox2.Controls.Add(this.LabelO);
            this.GroupBox2.Controls.Add(this.TextBoxO);
            this.GroupBox2.Controls.Add(this.LabelI);
            this.GroupBox2.Controls.Add(this.TextBoxI);
            this.GroupBox2.Controls.Add(this.LabelE);
            this.GroupBox2.Controls.Add(this.TextBoxE);
            this.GroupBox2.Controls.Add(this.LabelA);
            this.GroupBox2.Controls.Add(this.TextBoxA);
            this.GroupBox2.Location = new System.Drawing.Point(10, 80);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.GroupBox2.Size = new System.Drawing.Size(360, 210);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Tecles";
            // 
            // ButtonA
            // 
            this.ButtonA.BackgroundImage = global::MouseRunner.Properties.Resources.Roadrunner;
            this.ButtonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonA.FlatAppearance.BorderSize = 0;
            this.ButtonA.Location = new System.Drawing.Point(250, 20);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(20, 20);
            this.ButtonA.TabIndex = 2;
            this.ButtonA.UseVisualStyleBackColor = false;
            this.ButtonA.Click += new System.EventHandler(this.button_Click);
            // 
            // ButtonE
            // 
            this.ButtonE.BackgroundImage = global::MouseRunner.Properties.Resources.Roadrunner;
            this.ButtonE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonE.FlatAppearance.BorderSize = 0;
            this.ButtonE.Location = new System.Drawing.Point(250, 60);
            this.ButtonE.Name = "ButtonE";
            this.ButtonE.Size = new System.Drawing.Size(20, 20);
            this.ButtonE.TabIndex = 3;
            this.ButtonE.UseVisualStyleBackColor = false;
            this.ButtonE.Click += new System.EventHandler(this.button_Click);
            // 
            // ButtonI
            // 
            this.ButtonI.BackgroundImage = global::MouseRunner.Properties.Resources.Roadrunner;
            this.ButtonI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonI.FlatAppearance.BorderSize = 0;
            this.ButtonI.Location = new System.Drawing.Point(250, 100);
            this.ButtonI.Name = "ButtonI";
            this.ButtonI.Size = new System.Drawing.Size(20, 20);
            this.ButtonI.TabIndex = 4;
            this.ButtonI.UseVisualStyleBackColor = false;
            this.ButtonI.Click += new System.EventHandler(this.button_Click);
            // 
            // ButtonO
            // 
            this.ButtonO.BackgroundImage = global::MouseRunner.Properties.Resources.Roadrunner;
            this.ButtonO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonO.FlatAppearance.BorderSize = 0;
            this.ButtonO.Location = new System.Drawing.Point(250, 140);
            this.ButtonO.Name = "ButtonO";
            this.ButtonO.Size = new System.Drawing.Size(20, 20);
            this.ButtonO.TabIndex = 5;
            this.ButtonO.UseVisualStyleBackColor = false;
            this.ButtonO.Click += new System.EventHandler(this.button_Click);
            // 
            // ButtonU
            // 
            this.ButtonU.BackgroundImage = global::MouseRunner.Properties.Resources.Roadrunner;
            this.ButtonU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonU.FlatAppearance.BorderSize = 0;
            this.ButtonU.Location = new System.Drawing.Point(250, 180);
            this.ButtonU.Name = "ButtonU";
            this.ButtonU.Size = new System.Drawing.Size(20, 20);
            this.ButtonU.TabIndex = 6;
            this.ButtonU.UseVisualStyleBackColor = false;
            this.ButtonU.Click += new System.EventHandler(this.button_Click);
            // 
            // LabelU
            // 
            this.LabelU.CausesValidation = false;
            this.LabelU.Location = new System.Drawing.Point(110, 180);
            this.LabelU.Margin = new System.Windows.Forms.Padding(3);
            this.LabelU.Name = "LabelU";
            this.LabelU.Padding = new System.Windows.Forms.Padding(3);
            this.LabelU.Size = new System.Drawing.Size(20, 20);
            this.LabelU.TabIndex = 17;
            this.LabelU.Text = "U";
            this.LabelU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxU
            // 
            this.TextBoxU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxU.CausesValidation = false;
            this.TextBoxU.Enabled = false;
            this.TextBoxU.Location = new System.Drawing.Point(150, 180);
            this.TextBoxU.Name = "TextBoxU";
            this.TextBoxU.ShortcutsEnabled = false;
            this.TextBoxU.Size = new System.Drawing.Size(80, 20);
            this.TextBoxU.TabIndex = 0;
            this.TextBoxU.TabStop = false;
            this.TextBoxU.Text = "0";
            this.TextBoxU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelO
            // 
            this.LabelO.CausesValidation = false;
            this.LabelO.Location = new System.Drawing.Point(110, 140);
            this.LabelO.Margin = new System.Windows.Forms.Padding(3);
            this.LabelO.Name = "LabelO";
            this.LabelO.Padding = new System.Windows.Forms.Padding(3);
            this.LabelO.Size = new System.Drawing.Size(20, 20);
            this.LabelO.TabIndex = 14;
            this.LabelO.Text = "O";
            this.LabelO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxO
            // 
            this.TextBoxO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxO.CausesValidation = false;
            this.TextBoxO.Enabled = false;
            this.TextBoxO.Location = new System.Drawing.Point(150, 140);
            this.TextBoxO.Name = "TextBoxO";
            this.TextBoxO.ShortcutsEnabled = false;
            this.TextBoxO.Size = new System.Drawing.Size(80, 20);
            this.TextBoxO.TabIndex = 0;
            this.TextBoxO.TabStop = false;
            this.TextBoxO.Text = "0";
            this.TextBoxO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelI
            // 
            this.LabelI.CausesValidation = false;
            this.LabelI.Location = new System.Drawing.Point(110, 100);
            this.LabelI.Margin = new System.Windows.Forms.Padding(3);
            this.LabelI.Name = "LabelI";
            this.LabelI.Padding = new System.Windows.Forms.Padding(3);
            this.LabelI.Size = new System.Drawing.Size(20, 20);
            this.LabelI.TabIndex = 11;
            this.LabelI.Text = "I";
            this.LabelI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxI
            // 
            this.TextBoxI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxI.CausesValidation = false;
            this.TextBoxI.Enabled = false;
            this.TextBoxI.Location = new System.Drawing.Point(150, 100);
            this.TextBoxI.Name = "TextBoxI";
            this.TextBoxI.ShortcutsEnabled = false;
            this.TextBoxI.Size = new System.Drawing.Size(80, 20);
            this.TextBoxI.TabIndex = 0;
            this.TextBoxI.TabStop = false;
            this.TextBoxI.Text = "0";
            this.TextBoxI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelE
            // 
            this.LabelE.CausesValidation = false;
            this.LabelE.Location = new System.Drawing.Point(110, 60);
            this.LabelE.Margin = new System.Windows.Forms.Padding(3);
            this.LabelE.Name = "LabelE";
            this.LabelE.Padding = new System.Windows.Forms.Padding(3);
            this.LabelE.Size = new System.Drawing.Size(20, 20);
            this.LabelE.TabIndex = 8;
            this.LabelE.Text = "E";
            this.LabelE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxE
            // 
            this.TextBoxE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxE.CausesValidation = false;
            this.TextBoxE.Enabled = false;
            this.TextBoxE.Location = new System.Drawing.Point(150, 60);
            this.TextBoxE.Name = "TextBoxE";
            this.TextBoxE.ShortcutsEnabled = false;
            this.TextBoxE.Size = new System.Drawing.Size(80, 20);
            this.TextBoxE.TabIndex = 0;
            this.TextBoxE.TabStop = false;
            this.TextBoxE.Text = "0";
            this.TextBoxE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelA
            // 
            this.LabelA.CausesValidation = false;
            this.LabelA.Location = new System.Drawing.Point(110, 20);
            this.LabelA.Margin = new System.Windows.Forms.Padding(3);
            this.LabelA.Name = "LabelA";
            this.LabelA.Padding = new System.Windows.Forms.Padding(3);
            this.LabelA.Size = new System.Drawing.Size(20, 20);
            this.LabelA.TabIndex = 0;
            this.LabelA.Text = "A";
            this.LabelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxA
            // 
            this.TextBoxA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxA.CausesValidation = false;
            this.TextBoxA.Enabled = false;
            this.TextBoxA.Location = new System.Drawing.Point(150, 20);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.ShortcutsEnabled = false;
            this.TextBoxA.Size = new System.Drawing.Size(80, 20);
            this.TextBoxA.TabIndex = 0;
            this.TextBoxA.TabStop = false;
            this.TextBoxA.Text = "0";
            this.TextBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "MouseRunner";
            this.NotifyIcon.Visible = true;
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MostrarDades,
            this.Configuracio,
            this.ToolStripSeparator1,
            this.Sortir});
            this.ContextMenuStrip.Name = "contextMenuStrip1";
            this.ContextMenuStrip.Size = new System.Drawing.Size(151, 76);
            // 
            // MostrarDades
            // 
            this.MostrarDades.Name = "MostrarDades";
            this.MostrarDades.Size = new System.Drawing.Size(150, 22);
            this.MostrarDades.Text = "Mostrar Dades";
            this.MostrarDades.Click += new System.EventHandler(this.mostrarDades_Click);
            // 
            // Configuracio
            // 
            this.Configuracio.Name = "Configuracio";
            this.Configuracio.Size = new System.Drawing.Size(150, 22);
            this.Configuracio.Text = "Configuració";
            this.Configuracio.Click += new System.EventHandler(this.Configuracio_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // Sortir
            // 
            this.Sortir.Name = "Sortir";
            this.Sortir.Size = new System.Drawing.Size(150, 22);
            this.Sortir.Text = "Sortir";
            this.Sortir.Click += new System.EventHandler(this.Sortir_Click);
            // 
            // TmMouse
            // 
            this.TmMouse.Enabled = true;
            this.TmMouse.Interval = 20;
            this.TmMouse.Tick += new System.EventHandler(this.tmMouse_Tick);
            // 
            // TmTeclat
            // 
            this.TmTeclat.Enabled = true;
            this.TmTeclat.Interval = 20;
            this.TmTeclat.Tick += new System.EventHandler(this.TmTeclat_Tick);
            // 
            // FrmMostrarDades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.ButtonHide);
            this.Controls.Add(this.GroupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMostrarDades";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Dades - MouseRunner";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMostrarDades_FormClosed);
            this.Resize += new System.EventHandler(this.FrmMostrarDades_Resize);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label LabelM;
        private System.Windows.Forms.TextBox TextBoxM;
        private System.Windows.Forms.Button ButtonHide;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Label LabelA;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.Label LabelU;
        private System.Windows.Forms.TextBox TextBoxU;
        private System.Windows.Forms.Label LabelO;
        private System.Windows.Forms.TextBox TextBoxO;
        private System.Windows.Forms.Label LabelI;
        private System.Windows.Forms.TextBox TextBoxI;
        private System.Windows.Forms.Label LabelE;
        private System.Windows.Forms.TextBox TextBoxE;
        private System.Windows.Forms.Button ButtonM;
        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Button ButtonE;
        private System.Windows.Forms.Button ButtonI;
        private System.Windows.Forms.Button ButtonO;
        private System.Windows.Forms.Button ButtonU;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Timer TmMouse;
        private new System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MostrarDades;
        private System.Windows.Forms.ToolStripMenuItem Configuracio;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Sortir;
        private System.Windows.Forms.Timer TmTeclat;
    }
}

