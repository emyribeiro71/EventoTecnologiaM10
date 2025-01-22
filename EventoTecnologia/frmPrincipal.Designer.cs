namespace EventoTecnologia
{
    partial class frmPrincipal
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
            grpEventos = new GroupBox();
            btnInscrever = new Button();
            btnRemover = new Button();
            dgvEventos = new DataGridView();
            btnSair = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dudNumMax = new DomainUpDown();
            dtpData = new DateTimePicker();
            txtNome = new TextBox();
            ckbEvento = new CheckBox();
            grpEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // grpEventos
            // 
            grpEventos.Controls.Add(btnInscrever);
            grpEventos.Controls.Add(btnRemover);
            grpEventos.Controls.Add(dgvEventos);
            grpEventos.Location = new Point(22, 97);
            grpEventos.Name = "grpEventos";
            grpEventos.Size = new Size(610, 248);
            grpEventos.TabIndex = 1;
            grpEventos.TabStop = false;
            grpEventos.Text = "Participantes";
            // 
            // btnInscrever
            // 
            btnInscrever.Location = new Point(499, 139);
            btnInscrever.Name = "btnInscrever";
            btnInscrever.Size = new Size(90, 43);
            btnInscrever.TabIndex = 4;
            btnInscrever.Text = "Inscrever Participante";
            btnInscrever.UseVisualStyleBackColor = true;
            btnInscrever.Click += btnInscrever_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(499, 188);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(90, 43);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover Inscrição";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvEventos
            // 
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(22, 29);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.RowHeadersWidth = 82;
            dgvEventos.Size = new Size(459, 202);
            dgvEventos.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(533, 365);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 50);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 5;
            label3.Text = "N.º Máximo de Participantes";
            // 
            // dudNumMax
            // 
            dudNumMax.Location = new Point(446, 50);
            dudNumMax.Margin = new Padding(2, 1, 2, 1);
            dudNumMax.Name = "dudNumMax";
            dudNumMax.Size = new Size(55, 23);
            dudNumMax.TabIndex = 6;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(84, 52);
            dtpData.Margin = new Padding(2, 1, 2, 1);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(116, 23);
            dtpData.TabIndex = 7;
            dtpData.Value = new DateTime(2024, 12, 15, 0, 0, 0, 0);
            // 
            // txtNome
            // 
            txtNome.Location = new Point(86, 22);
            txtNome.Margin = new Padding(2, 1, 2, 1);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(417, 23);
            txtNome.TabIndex = 8;
            // 
            // ckbEvento
            // 
            ckbEvento.AutoSize = true;
            ckbEvento.Location = new Point(516, 29);
            ckbEvento.Name = "ckbEvento";
            ckbEvento.Size = new Size(95, 19);
            ckbEvento.TabIndex = 9;
            ckbEvento.Text = "Editar Evento";
            ckbEvento.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 401);
            Controls.Add(ckbEvento);
            Controls.Add(txtNome);
            Controls.Add(dtpData);
            Controls.Add(dudNumMax);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Controls.Add(grpEventos);
            Name = "frmPrincipal";
            Text = "Gestão de Inscrições para Evento de Tecnologia";
            Load += frmPrincipal_Load;
            KeyDown += frmPrincipal_KeyDown;
            grpEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpEventos;
        private DataGridView dgvEventos;
        private Button btnSair;
        private Button btnListParticipantes;
        private Button btnAddParticipante;
        private Button btnRemover;
        private Label label1;
        private Label label2;
        private Label label3;
        private DomainUpDown dudNumMax;
        private DateTimePicker dtpData;
        private TextBox txtNome;
        private Button btnAddEvento;
        private Button btnInscrever;
        private CheckBox ckbEvento;
    }
}
