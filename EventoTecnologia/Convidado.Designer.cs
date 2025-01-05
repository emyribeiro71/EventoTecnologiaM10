namespace EventoTecnologia
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
            lbl_Nome = new Label();
            lbl_Idade = new Label();
            lbl_Email = new Label();
            label4 = new Label();
            label5 = new Label();
            txb_Nome = new TextBox();
            txb_Email = new TextBox();
            txb_Idade = new TextBox();
            btn_ok = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(131, 87);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(46, 15);
            lbl_Nome.TabIndex = 0;
            lbl_Nome.Text = "Nome: ";
            // 
            // lbl_Idade
            // 
            lbl_Idade.AutoSize = true;
            lbl_Idade.Location = new Point(331, 87);
            lbl_Idade.Name = "lbl_Idade";
            lbl_Idade.Size = new Size(42, 15);
            lbl_Idade.TabIndex = 1;
            lbl_Idade.Text = "Idade: ";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(188, 133);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(39, 15);
            lbl_Email.TabIndex = 2;
            lbl_Email.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 30);
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
            // txb_Nome
            // 
            txb_Nome.Location = new Point(188, 84);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(100, 23);
            txb_Nome.TabIndex = 6;
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(233, 130);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(100, 23);
            txb_Email.TabIndex = 7;
            // 
            // txb_Idade
            // 
            txb_Idade.Location = new Point(379, 84);
            txb_Idade.Name = "txb_Idade";
            txb_Idade.Size = new Size(100, 23);
            txb_Idade.TabIndex = 8;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(477, 364);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 9;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(396, 364);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 10;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // Convidado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 399);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_ok);
            Controls.Add(txb_Idade);
            Controls.Add(txb_Email);
            Controls.Add(txb_Nome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Idade);
            Controls.Add(lbl_Nome);
            Name = "Convidado";
            Text = "Convidado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nome;
        private Label lbl_Idade;
        private Label lbl_Email;
        private Label label4;
        private Label label5;
        private TextBox txb_Nome;
        private TextBox txb_Email;
        private TextBox txb_Idade;
        private Button btn_ok;
        private Button btn_cancelar;
    }
}