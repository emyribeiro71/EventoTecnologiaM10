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
            dgvParticipantes = new DataGridView();
            btnSair = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dudNumMax = new DomainUpDown();
            dtpData = new DateTimePicker();
            txtNome = new TextBox();
            cmbEventos = new ComboBox();
            lblevento = new Label();
            btn = new Button();
            btnNewEvent = new Button();
            btnEditarEvent = new Button();
            grpEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            SuspendLayout();
            // 
            // grpEventos
            // 
            grpEventos.Controls.Add(btnInscrever);
            grpEventos.Controls.Add(btnRemover);
            grpEventos.Controls.Add(dgvParticipantes);
            grpEventos.Location = new Point(22, 97);
            grpEventos.Name = "grpEventos";
            grpEventos.Size = new Size(601, 248);
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
            // dgvParticipantes
            // 
            dgvParticipantes.AllowUserToOrderColumns = true;
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Location = new Point(22, 29);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.RowHeadersWidth = 82;
            dgvParticipantes.Size = new Size(459, 202);
            dgvParticipantes.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(675, 322);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(104, 23);
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
            // cmbEventos
            // 
            cmbEventos.FormattingEnabled = true;
            cmbEventos.Location = new Point(649, 35);
            cmbEventos.Name = "cmbEventos";
            cmbEventos.Size = new Size(163, 23);
            cmbEventos.TabIndex = 10;
            cmbEventos.Text = "[Escolha um evento]";
            cmbEventos.SelectedIndexChanged += cmbEventos_SelectedIndexChanged;
            // 
            // lblevento
            // 
            lblevento.AutoSize = true;
            lblevento.Location = new Point(594, 38);
            lblevento.Name = "lblevento";
            lblevento.Size = new Size(49, 15);
            lblevento.TabIndex = 11;
            lblevento.Text = "Evento: ";
            // 
            // btn
            // 
            btn.Location = new Point(0, 0);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 14;
            // 
            // btnNewEvent
            // 
            btnNewEvent.Location = new Point(675, 75);
            btnNewEvent.Name = "btnNewEvent";
            btnNewEvent.Size = new Size(104, 33);
            btnNewEvent.TabIndex = 13;
            btnNewEvent.Text = "Novo Evento";
            btnNewEvent.UseVisualStyleBackColor = true;
            btnNewEvent.Click += btnNewEvent_Click;
            // 
            // btnEditarEvent
            // 
            btnEditarEvent.Location = new Point(675, 114);
            btnEditarEvent.Name = "btnEditarEvent";
            btnEditarEvent.Size = new Size(104, 33);
            btnEditarEvent.TabIndex = 15;
            btnEditarEvent.Text = "Editar Evento";
            btnEditarEvent.UseVisualStyleBackColor = true;
            btnEditarEvent.Click += btnEditarEvent_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 357);
            Controls.Add(btnEditarEvent);
            Controls.Add(btnNewEvent);
            Controls.Add(btn);
            Controls.Add(lblevento);
            Controls.Add(cmbEventos);
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
            FormClosing += frmPrincipal_FormClosing;
            Load += frmPrincipal_Load;
            KeyDown += frmPrincipal_KeyDown;
            grpEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpEventos;
        private DataGridView dgvParticipantes;
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
        private ComboBox cmbEventos;
        private Label lblevento;
        private Button btn;
        private Button btnNewEvent;
        private Button btnEditarEvent;
    }
}
