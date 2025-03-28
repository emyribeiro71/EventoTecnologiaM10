﻿namespace EventoTecnologia
{
    partial class Convidado
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
            components = new System.ComponentModel.Container();
            lbl_Nome = new Label();
            lbl_Idade = new Label();
            lbl_Email = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Nome = new TextBox();
            txt_Email = new TextBox();
            txt_Idade = new TextBox();
            btn_ok = new Button();
            btn_cancelar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(40, 39);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(46, 15);
            lbl_Nome.TabIndex = 0;
            lbl_Nome.Text = "Nome: ";
            // 
            // lbl_Idade
            // 
            lbl_Idade.AutoSize = true;
            lbl_Idade.Location = new Point(40, 74);
            lbl_Idade.Name = "lbl_Idade";
            lbl_Idade.Size = new Size(42, 15);
            lbl_Idade.TabIndex = 1;
            lbl_Idade.Text = "Idade: ";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(214, 69);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(39, 15);
            lbl_Email.TabIndex = 2;
            lbl_Email.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 9);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Novo Participante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 312);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(92, 36);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(277, 23);
            txt_Nome.TabIndex = 6;
            txt_Nome.Validating += txb_Nome_Validating;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(259, 65);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(100, 23);
            txt_Email.TabIndex = 7;
            txt_Email.Validating += txb_Email_Validating;
            // 
            // txt_Idade
            // 
            txt_Idade.Location = new Point(92, 66);
            txt_Idade.Name = "txt_Idade";
            txt_Idade.Size = new Size(100, 23);
            txt_Idade.TabIndex = 8;
            txt_Idade.Validating += txb_Idade_Validating;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(138, 120);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 9;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(219, 120);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 10;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Convidado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 165);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_ok);
            Controls.Add(txt_Idade);
            Controls.Add(txt_Email);
            Controls.Add(txt_Nome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Idade);
            Controls.Add(lbl_Nome);
            Name = "Convidado";
            Text = "Convidado";
            Load += Convidado_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nome;
        private Label lbl_Idade;
        private Label lbl_Email;
        private Label label4;
        private Label label5;
        private TextBox txt_Nome;
        private TextBox txt_Email;
        private TextBox txt_Idade;
        private Button btn_ok;
        private Button btn_cancelar;
        private ErrorProvider errorProvider;
    }
}