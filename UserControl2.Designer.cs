namespace Proyecto_Diseño_UI_GUNA
{
    partial class UserControl2
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1_valid = new Guna.UI2.WinForms.Guna2Panel();
            guna2GradientButton1_valid = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1_valid.SuspendLayout();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1_valid
            // 
            guna2Panel1_valid.BackColor = Color.Transparent;
            guna2Panel1_valid.BorderColor = Color.PaleVioletRed;
            guna2Panel1_valid.BorderRadius = 2;
            guna2Panel1_valid.BorderThickness = 4;
            guna2Panel1_valid.Controls.Add(guna2GradientButton1_valid);
            guna2Panel1_valid.CustomizableEdges = customizableEdges3;
            guna2Panel1_valid.Dock = DockStyle.Fill;
            guna2Panel1_valid.Location = new Point(0, 0);
            guna2Panel1_valid.Name = "guna2Panel1_valid";
            guna2Panel1_valid.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1_valid.Size = new Size(150, 150);
            guna2Panel1_valid.TabIndex = 1;
            guna2Panel1_valid.Visible = false;
            guna2Panel1_valid.Click += guna2Panel1_valid_Click;
            guna2Panel1_valid.Paint += guna2Panel1_valid_Paint;
            // 
            // guna2GradientButton1_valid
            // 
            guna2GradientButton1_valid.BorderRadius = 4;
            guna2GradientButton1_valid.CustomizableEdges = customizableEdges1;
            guna2GradientButton1_valid.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1_valid.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1_valid.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1_valid.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1_valid.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1_valid.Font = new Font("Segoe UI", 9F);
            guna2GradientButton1_valid.ForeColor = Color.White;
            guna2GradientButton1_valid.Image = Properties.Resources.icons8_done_50;
            guna2GradientButton1_valid.ImageSize = new Size(30, 30);
            guna2GradientButton1_valid.Location = new Point(109, 111);
            guna2GradientButton1_valid.Name = "guna2GradientButton1_valid";
            guna2GradientButton1_valid.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientButton1_valid.Size = new Size(38, 36);
            guna2GradientButton1_valid.TabIndex = 1;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.BorderRadius = 5;
            guna2GradientPanel1.Controls.Add(guna2HtmlLabel1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.FillColor = Color.FromArgb(94, 148, 255);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 77, 165);
            guna2GradientPanel1.Location = new Point(13, 105);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Size = new Size(54, 22);
            guna2GradientPanel1.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonHighlight;
            guna2HtmlLabel1.Location = new Point(3, 0);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(46, 19);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "$15.000";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Screenshot_2025_06_09_1658093;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(guna2GradientPanel1);
            Controls.Add(guna2Panel1_valid);
            DoubleBuffered = true;
            Name = "UserControl2";
            Click += UserControl2_Click;
            guna2Panel1_valid.ResumeLayout(false);
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1_valid;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1_valid;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
