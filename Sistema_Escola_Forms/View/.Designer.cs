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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNota01 = new System.Windows.Forms.TextBox();
            this.txtNota02 = new System.Windows.Forms.TextBox();
            this.txtNota03 = new System.Windows.Forms.TextBox();
            this.txtNota04 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GridNotas = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.labelMedia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "BOLETIM";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(81, 596);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(125, 33);
            this.BtnVoltar.TabIndex = 23;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(518, 596);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(125, 33);
            this.BtnExcluir.TabIndex = 34;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(372, 596);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(125, 33);
            this.BtnEditar.TabIndex = 33;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nota 01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(936, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nota 04";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nota 03";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nota 02";
            // 
            // txtNota01
            // 
            this.txtNota01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota01.Location = new System.Drawing.Point(184, 416);
            this.txtNota01.Name = "txtNota01";
            this.txtNota01.Size = new System.Drawing.Size(119, 26);
            this.txtNota01.TabIndex = 40;
           
            this.txtNota01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota01_KeyPress_1);
            // 
            // txtNota02
            // 
            this.txtNota02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota02.Location = new System.Drawing.Point(476, 418);
            this.txtNota02.Name = "txtNota02";
            this.txtNota02.Size = new System.Drawing.Size(119, 26);
            this.txtNota02.TabIndex = 41;
          
            // 
            // txtNota03
            // 
            this.txtNota03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota03.Location = new System.Drawing.Point(763, 420);
            this.txtNota03.Name = "txtNota03";
            this.txtNota03.Size = new System.Drawing.Size(119, 26);
            this.txtNota03.TabIndex = 42;
            
            // txtNota04
            // 
            this.txtNota04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota04.Location = new System.Drawing.Point(1062, 422);
            this.txtNota04.Name = "txtNota04";
            this.txtNota04.Size = new System.Drawing.Size(119, 26);
            this.txtNota04.TabIndex = 43;
           
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 46;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridNotas
            // 
            this.GridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNotas.Location = new System.Drawing.Point(58, 117);
            this.GridNotas.Name = "GridNotas";
            this.GridNotas.Size = new System.Drawing.Size(1123, 262);
            this.GridNotas.TabIndex = 47;
          
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(64, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 33);
            this.button2.TabIndex = 48;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedia.Location = new System.Drawing.Point(216, 479);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(87, 31);
            this.labelMedia.TabIndex = 49;
            this.labelMedia.Text = "Média";
           
            // 
            // AdicionarNotaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 675);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridNotas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNota04);
            this.Controls.Add(this.txtNota03);
            this.Controls.Add(this.txtNota02);
            this.Controls.Add(this.txtNota01);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarNotaView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Boletim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNota01;
        private System.Windows.Forms.TextBox txtNota02;
        private System.Windows.Forms.TextBox txtNota03;
        private System.Windows.Forms.TextBox txtNota04;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridNotas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelMedia;
    }
}