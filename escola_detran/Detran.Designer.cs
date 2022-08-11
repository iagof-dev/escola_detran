namespace escola_detran
{
    partial class Detran
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
            if (disposing && (components != null))
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_form = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proprietarioToolStripMenuItem,
            this.veiculoToolStripMenuItem,
            this.agenteToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // proprietarioToolStripMenuItem
            // 
            this.proprietarioToolStripMenuItem.Name = "proprietarioToolStripMenuItem";
            this.proprietarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proprietarioToolStripMenuItem.Text = "Proprietário";
            this.proprietarioToolStripMenuItem.Click += new System.EventHandler(this.proprietarioToolStripMenuItem_Click);
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veiculoToolStripMenuItem.Text = "Veiculo";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click);
            // 
            // agenteToolStripMenuItem
            // 
            this.agenteToolStripMenuItem.Name = "agenteToolStripMenuItem";
            this.agenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agenteToolStripMenuItem.Text = "Agente";
            // 
            // pan_form
            // 
            this.pan_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_form.Location = new System.Drawing.Point(0, 24);
            this.pan_form.Name = "pan_form";
            this.pan_form.Size = new System.Drawing.Size(800, 426);
            this.pan_form.TabIndex = 3;
            this.pan_form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Detran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pan_form);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Detran";
            this.Text = "Detran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Detran_FormClosed);
            this.Load += new System.EventHandler(this.Detran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pan_form;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agenteToolStripMenuItem;
    }
}