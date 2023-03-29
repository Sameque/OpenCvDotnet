namespace WinFormsApp
{
    partial class frmOpenImg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            abrirImagemToolStripMenuItem = new ToolStripMenuItem();
            picImagem = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { abrirImagemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // abrirImagemToolStripMenuItem
            // 
            abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            abrirImagemToolStripMenuItem.Size = new Size(92, 20);
            abrirImagemToolStripMenuItem.Text = "Abrir imagem";
            abrirImagemToolStripMenuItem.Click += abrirImagemToolStripMenuItem_Click;
            // 
            // picImagem
            // 
            picImagem.Dock = DockStyle.Fill;
            picImagem.Location = new Point(0, 24);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(800, 426);
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagem.TabIndex = 1;
            picImagem.TabStop = false;
            // 
            // frmOpenImg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picImagem);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmOpenImg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abrir Imagem";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private PictureBox picImagem;
        private ToolStripMenuItem abrirImagemToolStripMenuItem;
    }
}