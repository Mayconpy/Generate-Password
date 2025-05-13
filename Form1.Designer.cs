namespace gerenciadordeappemexe
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cuiListbox1 = new CuoreUI.Controls.cuiListbox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // cuiListbox1
            // 
            this.cuiListbox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiListbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cuiListbox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cuiListbox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.cuiListbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.cuiListbox1.ForegroundColor = System.Drawing.Color.DimGray;
            this.cuiListbox1.FormattingEnabled = true;
            this.cuiListbox1.ItemHeight = 34;
            this.cuiListbox1.ItemHoveredBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cuiListbox1.ItemHoveredForegroundColor = System.Drawing.Color.Gray;
            this.cuiListbox1.ItemRounding = 8;
            this.cuiListbox1.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiListbox1.Location = new System.Drawing.Point(-1, -2);
            this.cuiListbox1.Name = "cuiListbox1";
            this.cuiListbox1.Rounding = 8;
            this.cuiListbox1.SelectedForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(12)))));
            this.cuiListbox1.Size = new System.Drawing.Size(337, 340);
            this.cuiListbox1.TabIndex = 2;
            this.cuiListbox1.SelectedIndexChanged += new System.EventHandler(this.cuiListbox1_SelectedIndexChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            this.guna2AnimateWindow1.Interval = 700;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(334, 340);
            this.Controls.Add(this.cuiListbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiListbox cuiListbox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

