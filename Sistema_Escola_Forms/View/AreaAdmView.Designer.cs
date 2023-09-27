namespace Sistema_Escola_Forms.view
{
    partial class AreaAdmView
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
            this.BtnCriarAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBoletim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCriarAluno
            // 
            this.BtnCriarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCriarAluno.Location = new System.Drawing.Point(113, 169);
            this.BtnCriarAluno.Name = "BtnCriarAluno";
            this.BtnCriarAluno.Size = new System.Drawing.Size(161, 84);
            this.BtnCriarAluno.TabIndex = 0;
            this.BtnCriarAluno.Text = " ALUNO";
            this.BtnCriarAluno.UseVisualStyleBackColor = true;
            this.BtnCriarAluno.Click += new System.EventHandler(this.BtnCriarProfessor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMINISTRAÇÃO";
            // 
            // BtnBoletim
            // 
            this.BtnBoletim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBoletim.Location = new System.Drawing.Point(113, 259);
            this.BtnBoletim.Name = "BtnBoletim";
            this.BtnBoletim.Size = new System.Drawing.Size(161, 84);
            this.BtnBoletim.TabIndex = 4;
            this.BtnBoletim.Text = "BOLETIM";
            this.BtnBoletim.UseVisualStyleBackColor = true;
            this.BtnBoletim.Click += new System.EventHandler(this.BtnBoletim_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "Professores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AreaAdmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBoletim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCriarAluno);
            this.Name = "AreaAdmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area_Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCriarAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBoletim;
        private System.Windows.Forms.Button button1;
    }
}