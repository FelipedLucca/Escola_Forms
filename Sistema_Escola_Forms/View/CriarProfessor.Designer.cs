namespace Sistema_Escola_Forms.View
{
    partial class CriarProfessor
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
            this.GridProfessor = new System.Windows.Forms.DataGridView();
            this.RA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoProfessor = new System.Windows.Forms.TextBox();
            this.TextNomeProfessor = new System.Windows.Forms.TextBox();
            this.CbClasseProfessor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idadeProfessor = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbSexoProfessor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExcluirProfessor = new System.Windows.Forms.Button();
            this.BtnProfessor = new System.Windows.Forms.Button();
            this.BtnNovoProfessor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnVoltarAreaProfessor = new System.Windows.Forms.Button();
            this.LABELMATÉRIA = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // GridProfessor
            // 
            this.GridProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridProfessor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProfessor.Location = new System.Drawing.Point(66, 270);
            this.GridProfessor.Name = "GridProfessor";
            this.GridProfessor.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProfessor.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProfessor.Size = new System.Drawing.Size(678, 158);
            this.GridProfessor.TabIndex = 29;
            this.GridProfessor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProfessor_CellClick);
            // 
            // RA
            // 
            this.RA.AutoSize = true;
            this.RA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RA.Location = new System.Drawing.Point(439, 141);
            this.RA.Name = "RA";
            this.RA.Size = new System.Drawing.Size(71, 24);
            this.RA.TabIndex = 35;
            this.RA.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "PROFESSOR";
            // 
            // CodigoProfessor
            // 
            this.CodigoProfessor.Enabled = false;
            this.CodigoProfessor.Location = new System.Drawing.Point(565, 141);
            this.CodigoProfessor.Name = "CodigoProfessor";
            this.CodigoProfessor.ReadOnly = true;
            this.CodigoProfessor.Size = new System.Drawing.Size(175, 20);
            this.CodigoProfessor.TabIndex = 33;
            // 
            // TextNomeProfessor
            // 
            this.TextNomeProfessor.Enabled = false;
            this.TextNomeProfessor.Location = new System.Drawing.Point(192, 96);
            this.TextNomeProfessor.Name = "TextNomeProfessor";
            this.TextNomeProfessor.Size = new System.Drawing.Size(158, 20);
            this.TextNomeProfessor.TabIndex = 32;
            this.TextNomeProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNomeProfessor_KeyPress);
            // 
            // CbClasseProfessor
            // 
            this.CbClasseProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbClasseProfessor.Enabled = false;
            this.CbClasseProfessor.FormattingEnabled = true;
            this.CbClasseProfessor.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C",
            "2A",
            "2B",
            "2C"});
            this.CbClasseProfessor.Location = new System.Drawing.Point(565, 95);
            this.CbClasseProfessor.Name = "CbClasseProfessor";
            this.CbClasseProfessor.Size = new System.Drawing.Size(175, 21);
            this.CbClasseProfessor.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Classe";
            // 
            // idadeProfessor
            // 
            this.idadeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeProfessor.Location = new System.Drawing.Point(192, 193);
            this.idadeProfessor.MaxDate = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            this.idadeProfessor.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.idadeProfessor.Name = "idadeProfessor";
            this.idadeProfessor.Size = new System.Drawing.Size(158, 24);
            this.idadeProfessor.TabIndex = 28;
            this.idadeProfessor.Value = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sexo";
            // 
            // CbSexoProfessor
            // 
            this.CbSexoProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSexoProfessor.Enabled = false;
            this.CbSexoProfessor.FormattingEnabled = true;
            this.CbSexoProfessor.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.CbSexoProfessor.Location = new System.Drawing.Point(192, 141);
            this.CbSexoProfessor.Name = "CbSexoProfessor";
            this.CbSexoProfessor.Size = new System.Drawing.Size(158, 21);
            this.CbSexoProfessor.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome";
            // 
            // BtnExcluirProfessor
            // 
            this.BtnExcluirProfessor.Location = new System.Drawing.Point(486, 453);
            this.BtnExcluirProfessor.Name = "BtnExcluirProfessor";
            this.BtnExcluirProfessor.Size = new System.Drawing.Size(125, 41);
            this.BtnExcluirProfessor.TabIndex = 40;
            this.BtnExcluirProfessor.Text = "EXCLUIR";
            this.BtnExcluirProfessor.UseVisualStyleBackColor = true;
            this.BtnExcluirProfessor.Click += new System.EventHandler(this.BtnExcluirProfessor_Click);
            // 
            // BtnProfessor
            // 
            this.BtnProfessor.Location = new System.Drawing.Point(346, 453);
            this.BtnProfessor.Name = "BtnProfessor";
            this.BtnProfessor.Size = new System.Drawing.Size(125, 40);
            this.BtnProfessor.TabIndex = 39;
            this.BtnProfessor.Text = "EDITAR";
            this.BtnProfessor.UseVisualStyleBackColor = true;
            this.BtnProfessor.Click += new System.EventHandler(this.BtnProfessor_Click);
            // 
            // BtnNovoProfessor
            // 
            this.BtnNovoProfessor.Location = new System.Drawing.Point(66, 453);
            this.BtnNovoProfessor.Name = "BtnNovoProfessor";
            this.BtnNovoProfessor.Size = new System.Drawing.Size(115, 40);
            this.BtnNovoProfessor.TabIndex = 38;
            this.BtnNovoProfessor.Text = "NOVO";
            this.BtnNovoProfessor.UseVisualStyleBackColor = true;
            this.BtnNovoProfessor.Click += new System.EventHandler(this.BtnNovoProfessor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 40);
            this.button2.TabIndex = 37;
            this.button2.Text = "CRIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnCriarProfessor_Click);
            // 
            // BtnVoltarAreaProfessor
            // 
            this.BtnVoltarAreaProfessor.Location = new System.Drawing.Point(627, 453);
            this.BtnVoltarAreaProfessor.Name = "BtnVoltarAreaProfessor";
            this.BtnVoltarAreaProfessor.Size = new System.Drawing.Size(117, 40);
            this.BtnVoltarAreaProfessor.TabIndex = 36;
            this.BtnVoltarAreaProfessor.Text = "VOLTAR";
            this.BtnVoltarAreaProfessor.UseVisualStyleBackColor = true;
            this.BtnVoltarAreaProfessor.Click += new System.EventHandler(this.BtnVoltarAreaProfessor_Click);
            // 
            // LABELMATÉRIA
            // 
            this.LABELMATÉRIA.AutoSize = true;
            this.LABELMATÉRIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELMATÉRIA.Location = new System.Drawing.Point(439, 194);
            this.LABELMATÉRIA.Name = "LABELMATÉRIA";
            this.LABELMATÉRIA.Size = new System.Drawing.Size(71, 24);
            this.LABELMATÉRIA.TabIndex = 41;
            this.LABELMATÉRIA.Text = "Matéria";
            // 
            // TxtMateria
            // 
            this.TxtMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtMateria.Enabled = false;
            this.TxtMateria.FormattingEnabled = true;
            this.TxtMateria.Items.AddRange(new object[] {
            "Matematica",
            "Língua Portuguesa",
            "Historia",
            "Física",
            "Biologia",
            "Química",
            "Geografia",
            "Filosofia",
            "Inglês"});
            this.TxtMateria.Location = new System.Drawing.Point(565, 199);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(175, 21);
            this.TxtMateria.TabIndex = 42;
            // 
            // CriarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 516);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.LABELMATÉRIA);
            this.Controls.Add(this.BtnExcluirProfessor);
            this.Controls.Add(this.BtnProfessor);
            this.Controls.Add(this.BtnNovoProfessor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnVoltarAreaProfessor);
            this.Controls.Add(this.GridProfessor);
            this.Controls.Add(this.RA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoProfessor);
            this.Controls.Add(this.TextNomeProfessor);
            this.Controls.Add(this.CbClasseProfessor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idadeProfessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbSexoProfessor);
            this.Controls.Add(this.label2);
            this.Name = "CriarProfessor";
            this.Text = "CriarProfessor";
            this.Load += new System.EventHandler(this.CriarProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridProfessor;
        private System.Windows.Forms.Label RA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoProfessor;
        private System.Windows.Forms.TextBox TextNomeProfessor;
        private System.Windows.Forms.ComboBox CbClasseProfessor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker idadeProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbSexoProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExcluirProfessor;
        private System.Windows.Forms.Button BtnProfessor;
        private System.Windows.Forms.Button BtnNovoProfessor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnVoltarAreaProfessor;
        private System.Windows.Forms.Label LABELMATÉRIA;
        private System.Windows.Forms.ComboBox TxtMateria;
    }
}