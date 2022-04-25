﻿
namespace NovoControleDeHorarios.br.com.projeto.view {
    partial class FrmPonto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txt_EntraSai = new System.Windows.Forms.TextBox();
            this.txt_Horario = new System.Windows.Forms.MaskedTextBox();
            this.txt_Data = new System.Windows.Forms.MaskedTextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txt_SenhaPonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_EntraSai
            // 
            this.txt_EntraSai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_EntraSai.Location = new System.Drawing.Point(85, 129);
            this.txt_EntraSai.MaxLength = 1;
            this.txt_EntraSai.Name = "txt_EntraSai";
            this.txt_EntraSai.Size = new System.Drawing.Size(28, 24);
            this.txt_EntraSai.TabIndex = 9;
            this.txt_EntraSai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EntraSai.TextChanged += new System.EventHandler(this.txt_EntraSai_TextChanged);
            // 
            // txt_Horario
            // 
            this.txt_Horario.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_Horario.Location = new System.Drawing.Point(193, 57);
            this.txt_Horario.Mask = "00:00";
            this.txt_Horario.Name = "txt_Horario";
            this.txt_Horario.ReadOnly = true;
            this.txt_Horario.Size = new System.Drawing.Size(44, 24);
            this.txt_Horario.TabIndex = 14;
            this.txt_Horario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Horario.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Data
            // 
            this.txt_Data.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_Data.Location = new System.Drawing.Point(71, 57);
            this.txt_Data.Mask = "00/00/0000";
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.ReadOnly = true;
            this.txt_Data.Size = new System.Drawing.Size(93, 24);
            this.txt_Data.TabIndex = 13;
            this.txt_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Data.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salvar.Location = new System.Drawing.Point(116, 170);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(84, 38);
            this.btn_Salvar.TabIndex = 12;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // txt_SenhaPonto
            // 
            this.txt_SenhaPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_SenhaPonto.Location = new System.Drawing.Point(129, 129);
            this.txt_SenhaPonto.MaxLength = 4;
            this.txt_SenhaPonto.Name = "txt_SenhaPonto";
            this.txt_SenhaPonto.Size = new System.Drawing.Size(100, 26);
            this.txt_SenhaPonto.TabIndex = 10;
            this.txt_SenhaPonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SenhaPonto.UseSystemPasswordChar = true;
            this.txt_SenhaPonto.TextChanged += new System.EventHandler(this.txt_Senha_TextChanged);
            this.txt_SenhaPonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SenhaPonto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(151, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data e Hora:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(71, 233);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.ReadOnly = true;
            this.txt_Nome.Size = new System.Drawing.Size(166, 20);
            this.txt_Nome.TabIndex = 16;
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Location = new System.Drawing.Point(71, 259);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.ReadOnly = true;
            this.txt_Cpf.Size = new System.Drawing.Size(166, 20);
            this.txt_Cpf.TabIndex = 19;
            this.txt_Cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(81, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "E/S";
            // 
            // FrmPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_EntraSai);
            this.Controls.Add(this.txt_Horario);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_SenhaPonto);
            this.Controls.Add(this.label2);
            this.Name = "FrmPonto";
            this.Text = "FrmPonto";
            this.Load += new System.EventHandler(this.FrmPonto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_EntraSai;
        private System.Windows.Forms.MaskedTextBox txt_Horario;
        private System.Windows.Forms.MaskedTextBox txt_Data;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_SenhaPonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.Label label3;
    }
}