namespace Sistema_Escola_Forms.View
{
    partial class LoginProfessorView
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
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.GridProfessor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoProfessor = new System.Windows.Forms.TextBox();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextNomeProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbClasseProfessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(331, 443);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(126, 44);
            this.BtnEntrar.TabIndex = 4;
            this.BtnEntrar.Text = "LOGIN";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // GridProfessor
            // 
            this.GridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProfessor.Location = new System.Drawing.Point(89, 64);
            this.GridProfessor.Name = "GridProfessor";
            this.GridProfessor.Size = new System.Drawing.Size(628, 239);
            this.GridProfessor.TabIndex = 5;
            this.GridProfessor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProfessor_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // CodigoProfessor
            // 
            this.CodigoProfessor.Location = new System.Drawing.Point(174, 337);
            this.CodigoProfessor.Name = "CodigoProfessor";
            this.CodigoProfessor.Size = new System.Drawing.Size(170, 20);
            this.CodigoProfessor.TabIndex = 7;
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(547, 337);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(170, 20);
            this.TxtMateria.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Materia";
            // 
            // TextNomeProfessor
            // 
            this.TextNomeProfessor.Location = new System.Drawing.Point(174, 388);
            this.TextNomeProfessor.Name = "TextNomeProfessor";
            this.TextNomeProfessor.Size = new System.Drawing.Size(170, 20);
            this.TextNomeProfessor.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome ";
            // 
            // CbClasseProfessor
            // 
            this.CbClasseProfessor.Location = new System.Drawing.Point(547, 388);
            this.CbClasseProfessor.Name = "CbClasseProfessor";
            this.CbClasseProfessor.Size = new System.Drawing.Size(170, 20);
            this.CbClasseProfessor.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Classe";
            // 
            // LoginProfessorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 516);
            this.Controls.Add(this.CbClasseProfessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextNomeProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridProfessor);
            this.Controls.Add(this.BtnEntrar);
            this.Name = "LoginProfessorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginProfessorView";
            this.Load += new System.EventHandler(this.LoginProfessorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.DataGridView GridProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoProfessor;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextNomeProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CbClasseProfessor;
        private System.Windows.Forms.Label label4;
    }
}