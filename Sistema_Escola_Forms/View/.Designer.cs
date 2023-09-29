namespace Sistema_Escola_Forms.View
{
    partial class AdicionarNotaView
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
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNota01 = new System.Windows.Forms.TextBox();
            this.txtNota02 = new System.Windows.Forms.TextBox();
            this.txtNota03 = new System.Windows.Forms.TextBox();
            this.txtNota04 = new System.Windows.Forms.TextBox();
            this.BBtnSalvarNota = new System.Windows.Forms.Button();
            this.GridNotas = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.labelMedia = new System.Windows.Forms.Label();
            this.labelNota01 = new System.Windows.Forms.Label();
            this.labelNota33 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.LabelSituacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRaAluno = new System.Windows.Forms.TextBox();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(240, 489);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(100, 35);
            this.BtnVoltar.TabIndex = 23;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(507, 489);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(102, 35);
            this.BtnExcluir.TabIndex = 34;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nota 01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nota 04";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nota 03";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nota 02";
            // 
            // txtNota01
            // 
            this.txtNota01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota01.Location = new System.Drawing.Point(265, 385);
            this.txtNota01.Name = "txtNota01";
            this.txtNota01.Size = new System.Drawing.Size(92, 21);
            this.txtNota01.TabIndex = 40;
            this.txtNota01.TextChanged += new System.EventHandler(this.txtNota01_TextChanged);
            this.txtNota01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota01_KeyPress_1);
            // 
            // txtNota02
            // 
            this.txtNota02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota02.Location = new System.Drawing.Point(474, 387);
            this.txtNota02.Name = "txtNota02";
            this.txtNota02.Size = new System.Drawing.Size(92, 22);
            this.txtNota02.TabIndex = 41;
            // 
            // txtNota03
            // 
            this.txtNota03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota03.Location = new System.Drawing.Point(265, 433);
            this.txtNota03.Name = "txtNota03";
            this.txtNota03.Size = new System.Drawing.Size(92, 21);
            this.txtNota03.TabIndex = 42;
            // 
            // txtNota04
            // 
            this.txtNota04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota04.Location = new System.Drawing.Point(474, 432);
            this.txtNota04.Name = "txtNota04";
            this.txtNota04.Size = new System.Drawing.Size(92, 21);
            this.txtNota04.TabIndex = 43;
            // 
            // BBtnSalvarNota
            // 
            this.BBtnSalvarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBtnSalvarNota.Location = new System.Drawing.Point(371, 489);
            this.BBtnSalvarNota.Name = "BBtnSalvarNota";
            this.BBtnSalvarNota.Size = new System.Drawing.Size(104, 35);
            this.BBtnSalvarNota.TabIndex = 46;
            this.BBtnSalvarNota.Text = "SALVAR";
            this.BBtnSalvarNota.UseVisualStyleBackColor = true;
            this.BBtnSalvarNota.Click += new System.EventHandler(this.BtnSalvarNota_Click);
            // 
            // GridNotas
            // 
            this.GridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classe,
            this.Ra,
            this.nomeAluno,
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Nota4});
            this.GridNotas.Location = new System.Drawing.Point(92, 87);
            this.GridNotas.Name = "GridNotas";
            this.GridNotas.Size = new System.Drawing.Size(744, 247);
            this.GridNotas.TabIndex = 47;
            this.GridNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridNotas_CellClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(607, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 48;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedia.Location = new System.Drawing.Point(715, 376);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(87, 31);
            this.labelMedia.TabIndex = 49;
            this.labelMedia.Text = "Média";
            // 
            // labelNota01
            // 
            this.labelNota01.AutoSize = true;
            this.labelNota01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota01.Location = new System.Drawing.Point(-2, 391);
            this.labelNota01.Name = "labelNota01";
            this.labelNota01.Size = new System.Drawing.Size(0, 20);
            this.labelNota01.TabIndex = 50;
            // 
            // labelNota33
            // 
            this.labelNota33.AutoSize = true;
            this.labelNota33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota33.Location = new System.Drawing.Point(332, 206);
            this.labelNota33.Name = "labelNota33";
            this.labelNota33.Size = new System.Drawing.Size(0, 20);
            this.labelNota33.TabIndex = 52;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(476, 537);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(0, 13);
            this.label55.TabIndex = 54;
            // 
            // LabelSituacao
            // 
            this.LabelSituacao.AutoSize = true;
            this.LabelSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSituacao.Location = new System.Drawing.Point(717, 430);
            this.LabelSituacao.Name = "LabelSituacao";
            this.LabelSituacao.Size = new System.Drawing.Size(82, 24);
            this.LabelSituacao.TabIndex = 55;
            this.LabelSituacao.Text = "Situação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ra Aluno :";
            // 
            // TxtRaAluno
            // 
            this.TxtRaAluno.Location = new System.Drawing.Point(267, 351);
            this.TxtRaAluno.Name = "TxtRaAluno";
            this.TxtRaAluno.Size = new System.Drawing.Size(100, 20);
            this.TxtRaAluno.TabIndex = 57;
            // 
            // classe
            // 
            this.classe.DataPropertyName = "classe";
            this.classe.HeaderText = "classe";
            this.classe.Name = "classe";
            // 
            // Ra
            // 
            this.Ra.DataPropertyName = "ra";
            this.Ra.HeaderText = "RA";
            this.Ra.Name = "Ra";
            // 
            // nomeAluno
            // 
            this.nomeAluno.DataPropertyName = "nome";
            this.nomeAluno.HeaderText = "Nome";
            this.nomeAluno.Name = "nomeAluno";
            // 
            // Nota1
            // 
            this.Nota1.DataPropertyName = "nota1";
            this.Nota1.HeaderText = "Nota 1";
            this.Nota1.Name = "Nota1";
            // 
            // Nota2
            // 
            this.Nota2.DataPropertyName = "nota2";
            this.Nota2.HeaderText = "Nota 2 ";
            this.Nota2.Name = "Nota2";
            // 
            // Nota3
            // 
            this.Nota3.DataPropertyName = "nota3";
            this.Nota3.HeaderText = "Nota 3";
            this.Nota3.Name = "Nota3";
            // 
            // Nota4
            // 
            this.Nota4.DataPropertyName = "nota4";
            this.Nota4.HeaderText = "Nota 4";
            this.Nota4.Name = "Nota4";
            // 
            // AdicionarNotaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 536);
            this.Controls.Add(this.TxtRaAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelSituacao);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.labelNota33);
            this.Controls.Add(this.labelNota01);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridNotas);
            this.Controls.Add(this.BBtnSalvarNota);
            this.Controls.Add(this.txtNota04);
            this.Controls.Add(this.txtNota03);
            this.Controls.Add(this.txtNota02);
            this.Controls.Add(this.txtNota01);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnVoltar);
            this.Name = "AdicionarNotaView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Boletim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNota01;
        private System.Windows.Forms.TextBox txtNota02;
        private System.Windows.Forms.TextBox txtNota03;
        private System.Windows.Forms.TextBox txtNota04;
        private System.Windows.Forms.Button BBtnSalvarNota;
        private System.Windows.Forms.DataGridView GridNotas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.Label labelNota01;
        private System.Windows.Forms.Label labelNota33;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label LabelSituacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRaAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
    }
}