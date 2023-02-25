using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    partial class principalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        //private System.Windows.Forms.MenuStrip menuStrip1()
        //{
        //    this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        //    this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
        //    this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        //    { this.Main,this.ReportsTSM});
        //    this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        //    this.menuStrip1.Name = "menuStrip1";
        //    this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        //    this.menuStrip1.Size = new System.Drawing.Size(589, 24);
        //    this.menuStrip1.TabIndex = 10;
        //    this.menuStrip1.Text = "menuStrip1";
        //    this.menuStrip1.ResumeLayout(false);
        //    this.menuStrip1.PerformLayout();
        //    this.Controls.Add(this.menuStrip1);
        //}
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
        /// 

    private void InitializeComponent()
        {
            this.teste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teste1StripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teste
            // 
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(180, 22);
            this.teste.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testeStripMenuItem1
            // 
            this.testeStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste1StripMenuItem1,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.testeStripMenuItem1.Name = "testeStripMenuItem1";
            this.testeStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.testeStripMenuItem1.Text = "Arquivo";
            // 
            // teste1StripMenuItem1
            // 
            this.teste1StripMenuItem1.Name = "teste1StripMenuItem1";
            this.teste1StripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.teste1StripMenuItem1.Text = "Clientes";
            this.teste1StripMenuItem1.Click += new System.EventHandler(this.teste1StripMenuItem1_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "principalForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.principalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem teste;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem testeStripMenuItem1;
        private ToolStripMenuItem teste1StripMenuItem1;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}