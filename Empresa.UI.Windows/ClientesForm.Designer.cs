﻿namespace Empresa.UI.Windows
{
    partial class ClientesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.novoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.confirmarIncluirButton = new System.Windows.Forms.Button();
            this.confirmarAlterarButton = new System.Windows.Forms.Button();
            this.confirmarExcluirButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.conteudoPanel = new System.Windows.Forms.Panel();
            this.fichaPanel = new System.Windows.Forms.Panel();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.conteudoPanel.SuspendLayout();
            this.fichaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 40);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.novoButton);
            this.flowLayoutPanel1.Controls.Add(this.alterarButton);
            this.flowLayoutPanel1.Controls.Add(this.excluirButton);
            this.flowLayoutPanel1.Controls.Add(this.sairButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarIncluirButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarAlterarButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarExcluirButton);
            this.flowLayoutPanel1.Controls.Add(this.voltarButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 6, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(714, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(13, 9);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 0;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(94, 9);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 1;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(175, 9);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(256, 9);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // confirmarIncluirButton
            // 
            this.confirmarIncluirButton.Location = new System.Drawing.Point(337, 9);
            this.confirmarIncluirButton.Name = "confirmarIncluirButton";
            this.confirmarIncluirButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarIncluirButton.TabIndex = 4;
            this.confirmarIncluirButton.Text = "Gravar";
            this.confirmarIncluirButton.UseVisualStyleBackColor = true;
            this.confirmarIncluirButton.Click += new System.EventHandler(this.confirmarIncluirButton_Click);
            // 
            // confirmarAlterarButton
            // 
            this.confirmarAlterarButton.Location = new System.Drawing.Point(418, 9);
            this.confirmarAlterarButton.Name = "confirmarAlterarButton";
            this.confirmarAlterarButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarAlterarButton.TabIndex = 6;
            this.confirmarAlterarButton.Text = "Alterar";
            this.confirmarAlterarButton.UseVisualStyleBackColor = true;
            this.confirmarAlterarButton.Click += new System.EventHandler(this.confirmarAlterarButton_Click);
            // 
            // confirmarExcluirButton
            // 
            this.confirmarExcluirButton.Location = new System.Drawing.Point(499, 9);
            this.confirmarExcluirButton.Name = "confirmarExcluirButton";
            this.confirmarExcluirButton.Size = new System.Drawing.Size(126, 23);
            this.confirmarExcluirButton.TabIndex = 5;
            this.confirmarExcluirButton.Text = "Confirmar Exclusão";
            this.confirmarExcluirButton.UseVisualStyleBackColor = true;
            this.confirmarExcluirButton.Click += new System.EventHandler(this.confirmarExcluirButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(631, 9);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 7;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // conteudoPanel
            // 
            this.conteudoPanel.Controls.Add(this.fichaPanel);
            this.conteudoPanel.Controls.Add(this.listaDataGridView);
            this.conteudoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteudoPanel.Location = new System.Drawing.Point(0, 0);
            this.conteudoPanel.Name = "conteudoPanel";
            this.conteudoPanel.Padding = new System.Windows.Forms.Padding(10);
            this.conteudoPanel.Size = new System.Drawing.Size(714, 267);
            this.conteudoPanel.TabIndex = 1;
            // 
            // fichaPanel
            // 
            this.fichaPanel.Controls.Add(this.telefoneTextBox);
            this.fichaPanel.Controls.Add(this.emailTextBox);
            this.fichaPanel.Controls.Add(this.nomeTextBox);
            this.fichaPanel.Controls.Add(this.idTextBox);
            this.fichaPanel.Controls.Add(this.telefoneLabel);
            this.fichaPanel.Controls.Add(this.emailLabel);
            this.fichaPanel.Controls.Add(this.nomeLabel);
            this.fichaPanel.Controls.Add(this.idLabel);
            this.fichaPanel.Location = new System.Drawing.Point(7, 12);
            this.fichaPanel.Name = "fichaPanel";
            this.fichaPanel.Size = new System.Drawing.Size(340, 214);
            this.fichaPanel.TabIndex = 1;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefoneTextBox.Location = new System.Drawing.Point(87, 127);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(156, 23);
            this.telefoneTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Location = new System.Drawing.Point(87, 88);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(156, 23);
            this.emailTextBox.TabIndex = 14;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.Location = new System.Drawing.Point(87, 48);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(156, 23);
            this.nomeTextBox.TabIndex = 13;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(87, 11);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(37, 23);
            this.idTextBox.TabIndex = 12;
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(18, 135);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(54, 15);
            this.telefoneLabel.TabIndex = 11;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(18, 96);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 15);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(18, 56);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(43, 15);
            this.nomeLabel.TabIndex = 9;
            this.nomeLabel.Text = "Nome:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(18, 19);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "Id";
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDataGridView.Location = new System.Drawing.Point(358, 13);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.RowTemplate.Height = 25;
            this.listaDataGridView.Size = new System.Drawing.Size(344, 213);
            this.listaDataGridView.TabIndex = 0;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 307);
            this.Controls.Add(this.conteudoPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.conteudoPanel.ResumeLayout(false);
            this.fichaPanel.ResumeLayout(false);
            this.fichaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button novoButton;
        private Button alterarButton;
        private Button excluirButton;
        private Button sairButton;
        private Button confirmarIncluirButton;
        private Button confirmarAlterarButton;
        private Button confirmarExcluirButton;
        private Panel conteudoPanel;
        private Panel fichaPanel;
        private DataGridView listaDataGridView;
        private TextBox telefoneTextBox;
        private TextBox emailTextBox;
        private TextBox nomeTextBox;
        private TextBox idTextBox;
        private Label telefoneLabel;
        private Label emailLabel;
        private Label nomeLabel;
        private Label idLabel;
        private Button voltarButton;
    }
}