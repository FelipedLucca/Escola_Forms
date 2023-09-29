namespace Sistema_Escola_Forms.view
{
    partial class NotaView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.CbSexoAluno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idadeProfessor = new System.Windows.Forms.DateTimePicker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.BtnVoltarAreaProfessor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CbturmaAluno = new System.Windows.Forms.ComboBox();
            this.TextNomeAluno = new System.Windows.Forms.TextBox();
            this.RaAluno = new System.Windows.Forms.TextBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExcluirAluno = new System.Windows.Forms.Button();
            this.RA = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // CbSexoAluno
            // 
            this.CbSexoAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSexoAluno.Enabled = false;
            this.CbSexoAluno.FormattingEnabled = true;
            this.CbSexoAluno.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.CbSexoAluno.Location = new System.Drawing.Point(173, 150);
            this.CbSexoAluno.Name = "CbSexoAluno";
            this.CbSexoAluno.Size = new System.Drawing.Size(158, 21);
            this.CbSexoAluno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nascimento";
            // 
            // idadeProfessor
            // 
            this.idadeProfessor.Enabled = false;
            this.idadeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeProfessor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.idadeProfessor.Location = new System.Drawing.Point(173, 202);
            this.idadeProfessor.MaxDate = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            this.idadeProfessor.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.idadeProfessor.Name = "idadeProfessor";
            this.idadeProfessor.Size = new System.Drawing.Size(158, 24);
            this.idadeProfessor.TabIndex = 6;
            this.idadeProfessor.Value = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // BtnVoltarAreaProfessor
            // 
            this.BtnVoltarAreaProfessor.Location = new System.Drawing.Point(28, 12);
            this.BtnVoltarAreaProfessor.Name = "BtnVoltarAreaProfessor";
            this.BtnVoltarAreaProfessor.Size = new System.Drawing.Size(81, 24);
            this.BtnVoltarAreaProfessor.TabIndex = 8;
            this.BtnVoltarAreaProfessor.Text = "VOLTAR";
            this.BtnVoltarAreaProfessor.UseVisualStyleBackColor = true;
            this.BtnVoltarAreaProfessor.Click += new System.EventHandler(this.BtnVoltarAreaProfessor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "CRIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnCriar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Classe";
            // 
            // CbturmaAluno
            // 
            this.CbturmaAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbturmaAluno.Enabled = false;
            this.CbturmaAluno.FormattingEnabled = true;
            this.CbturmaAluno.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C",
            "2A",
            "2B",
            "2C"});
            this.CbturmaAluno.Location = new System.Drawing.Point(496, 104);
            this.CbturmaAluno.Name = "CbturmaAluno";
            this.CbturmaAluno.Size = new System.Drawing.Size(175, 21);
            this.CbturmaAluno.TabIndex = 13;
            // 
            // TextNomeAluno
            // 
            this.TextNomeAluno.Enabled = false;
            this.TextNomeAluno.Location = new System.Drawing.Point(173, 105);
            this.TextNomeAluno.Name = "TextNomeAluno";
            this.TextNomeAluno.Size = new System.Drawing.Size(158, 20);
            this.TextNomeAluno.TabIndex = 16;
            this.TextNomeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNomeAluno_KeyPress);
            // 
            // RaAluno
            // 
            this.RaAluno.Enabled = false;
            this.RaAluno.Location = new System.Drawing.Point(496, 150);
            this.RaAluno.Name = "RaAluno";
            this.RaAluno.ReadOnly = true;
            this.RaAluno.Size = new System.Drawing.Size(175, 20);
            this.RaAluno.TabIndex = 17;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(350, 443);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(83, 29);
            this.BtnNovo.TabIndex = 19;
            this.BtnNovo.Text = "NOVO";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(861, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "ALUNOS";
            // 
            // BtnExcluirAluno
            // 
            this.BtnExcluirAluno.Location = new System.Drawing.Point(173, 443);
            this.BtnExcluirAluno.Name = "BtnExcluirAluno";
            this.BtnExcluirAluno.Size = new System.Drawing.Size(82, 29);
            this.BtnExcluirAluno.TabIndex = 22;
            this.BtnExcluirAluno.Text = "EXCLUIR";
            this.BtnExcluirAluno.UseVisualStyleBackColor = true;
            this.BtnExcluirAluno.Click += new System.EventHandler(this.BtnExcluirAluno_Click);
            // 
            // RA
            // 
            this.RA.AutoSize = true;
            this.RA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RA.Location = new System.Drawing.Point(373, 150);
            this.RA.Name = "RA";
            this.RA.Size = new System.Drawing.Size(36, 24);
            this.RA.TabIndex = 23;
            this.RA.Text = "RA";
            // 
            // Grid
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(50, 257);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.Size = new System.Drawing.Size(621, 170);
            this.Grid.TabIndex = 7;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 33);
            this.label5.TabIndex = 35;
            this.label5.Text = "ALUNO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NotaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.RA);
            this.Controls.Add(this.BtnExcluirAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.RaAluno);
            this.Controls.Add(this.TextNomeAluno);
            this.Controls.Add(this.CbturmaAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnVoltarAreaProfessor);
            this.Controls.Add(this.idadeProfessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbSexoAluno);
            this.Controls.Add(this.label2);
            this.Name = "NotaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar_Professor";
            this.Load += new System.EventHandler(this.CriarProfessorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbSexoAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker idadeProfessor;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox CbturmaAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnVoltarAreaProfessor;
        private System.Windows.Forms.TextBox TextNomeAluno;
        private System.Windows.Forms.TextBox RaAluno;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExcluirAluno;
        private System.Windows.Forms.Label RA;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label5;
    }
}