﻿namespace Empresa.UI.Windows
{
    partial class ClienteIncluirForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.incluirButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(45, 26);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(19, 63);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(43, 15);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(23, 103);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 15);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(8, 142);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(54, 15);
            this.telefoneLabel.TabIndex = 3;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(77, 24);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(37, 23);
            this.idTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.Location = new System.Drawing.Point(77, 61);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(156, 23);
            this.nomeTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Location = new System.Drawing.Point(77, 101);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(156, 23);
            this.emailTextBox.TabIndex = 6;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefoneTextBox.Location = new System.Drawing.Point(77, 140);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(156, 23);
            this.telefoneTextBox.TabIndex = 7;
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(139, 185);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 8;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(232, 185);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 9;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            // 
            // ClienteIncluirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 220);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.incluirButton);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "ClienteIncluirForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label idLabel;
        private Label nomeLabel;
        private Label emailLabel;
        private Label telefoneLabel;
        private TextBox idTextBox;
        private TextBox nomeTextBox;
        private TextBox emailTextBox;
        private TextBox telefoneTextBox;
        private Button incluirButton;
        private Button voltarButton;
    }
}