﻿namespace EventoTecnologia
{
    partial class Eventoss
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            domainUpDown1 = new DomainUpDown();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Evento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 76);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Data do Evento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 76);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 2;
            label3.Text = "Nº máximo de participantes:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(128, 76);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(105, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(417, 76);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(73, 23);
            domainUpDown1.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(153, 147);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(254, 147);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Eventoss
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 190);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(domainUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Eventoss";
            Text = "Evento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DomainUpDown domainUpDown1;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}