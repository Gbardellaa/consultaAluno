namespace consultaAluno
{
    partial class frmMatricula
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNomeAluno = new System.Windows.Forms.ComboBox();
            this.cmbNomeCurso = new System.Windows.Forms.ComboBox();
            this.cmbUnidadeEscolar = new System.Windows.Forms.ComboBox();
            this.cmbStatusMatricula = new System.Windows.Forms.ComboBox();
            this.dtpDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula de Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Matrícula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unidade Escolar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status Matricula";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbNomeAluno
            // 
            this.cmbNomeAluno.FormattingEnabled = true;
            this.cmbNomeAluno.Location = new System.Drawing.Point(243, 132);
            this.cmbNomeAluno.Name = "cmbNomeAluno";
            this.cmbNomeAluno.Size = new System.Drawing.Size(203, 21);
            this.cmbNomeAluno.TabIndex = 6;
            // 
            // cmbNomeCurso
            // 
            this.cmbNomeCurso.FormattingEnabled = true;
            this.cmbNomeCurso.Location = new System.Drawing.Point(243, 182);
            this.cmbNomeCurso.Name = "cmbNomeCurso";
            this.cmbNomeCurso.Size = new System.Drawing.Size(203, 21);
            this.cmbNomeCurso.TabIndex = 7;
            // 
            // cmbUnidadeEscolar
            // 
            this.cmbUnidadeEscolar.FormattingEnabled = true;
            this.cmbUnidadeEscolar.Location = new System.Drawing.Point(243, 270);
            this.cmbUnidadeEscolar.Name = "cmbUnidadeEscolar";
            this.cmbUnidadeEscolar.Size = new System.Drawing.Size(203, 21);
            this.cmbUnidadeEscolar.TabIndex = 9;
//            this.cmbUnidadeEscolar.SelectedIndexChanged += new System.EventHandler(this.cmbUnidadeEscolar_SelectedIndexChanged);
            // 
            // cmbStatusMatricula
            // 
            this.cmbStatusMatricula.FormattingEnabled = true;
            this.cmbStatusMatricula.Items.AddRange(new object[] {
            "Ativa",
            "Cancelada ",
            "Concluída"});
            this.cmbStatusMatricula.Location = new System.Drawing.Point(243, 316);
            this.cmbStatusMatricula.Name = "cmbStatusMatricula";
            this.cmbStatusMatricula.Size = new System.Drawing.Size(203, 21);
            this.cmbStatusMatricula.TabIndex = 10;
            // 
            // dtpDataMatricula
            // 
            this.dtpDataMatricula.Location = new System.Drawing.Point(247, 229);
            this.dtpDataMatricula.Name = "dtpDataMatricula";
            this.dtpDataMatricula.Size = new System.Drawing.Size(200, 20);
            this.dtpDataMatricula.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(329, 371);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(136, 38);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataMatricula);
            this.Controls.Add(this.cmbStatusMatricula);
            this.Controls.Add(this.cmbUnidadeEscolar);
            this.Controls.Add(this.cmbNomeCurso);
            this.Controls.Add(this.cmbNomeAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMatricula";
            this.Text = "frmMatricula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNomeAluno;
        private System.Windows.Forms.ComboBox cmbNomeCurso;
        private System.Windows.Forms.ComboBox cmbUnidadeEscolar;
        private System.Windows.Forms.ComboBox cmbStatusMatricula;
        private System.Windows.Forms.DateTimePicker dtpDataMatricula;
        private System.Windows.Forms.Button btnSalvar;
    }
}