﻿namespace consultaAluno
{
    partial class frmBuscarAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAddCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.btnAtualizarAluno = new System.Windows.Forms.Button();
            this.btnMatricularAluno = new System.Windows.Forms.Button();
            this.btnCadUnidEscolar = new System.Windows.Forms.Button();
            this.btnBuscaMatricula = new System.Windows.Forms.Button();
            this.btnBuscarUnidade = new System.Windows.Forms.Button();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.btnRelAlunos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar todos alunos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 271);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(661, 379);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(127, 41);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar ALuno";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAddCurso
            // 
            this.btnAddCurso.Location = new System.Drawing.Point(661, 426);
            this.btnAddCurso.Name = "btnAddCurso";
            this.btnAddCurso.Size = new System.Drawing.Size(127, 42);
            this.btnAddCurso.TabIndex = 3;
            this.btnAddCurso.Text = "Adicionar Curso";
            this.btnAddCurso.UseVisualStyleBackColor = true;
            this.btnAddCurso.Click += new System.EventHandler(this.btnAddCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aluno";
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAluno.Location = new System.Drawing.Point(86, 41);
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(191, 26);
            this.txtBuscarAluno.TabIndex = 5;
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAluno.Location = new System.Drawing.Point(295, 43);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAluno.TabIndex = 6;
            this.btnBuscarAluno.Text = "Buscar";
            this.btnBuscarAluno.UseVisualStyleBackColor = true;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // btnAtualizarAluno
            // 
            this.btnAtualizarAluno.Location = new System.Drawing.Point(142, 376);
            this.btnAtualizarAluno.Name = "btnAtualizarAluno";
            this.btnAtualizarAluno.Size = new System.Drawing.Size(103, 48);
            this.btnAtualizarAluno.TabIndex = 7;
            this.btnAtualizarAluno.Text = "Atualizar Aluno";
            this.btnAtualizarAluno.UseVisualStyleBackColor = true;
            this.btnAtualizarAluno.Click += new System.EventHandler(this.btnAtualizarAluno_Click);
            // 
            // btnMatricularAluno
            // 
            this.btnMatricularAluno.Location = new System.Drawing.Point(661, 474);
            this.btnMatricularAluno.Name = "btnMatricularAluno";
            this.btnMatricularAluno.Size = new System.Drawing.Size(127, 36);
            this.btnMatricularAluno.TabIndex = 8;
            this.btnMatricularAluno.Text = "Matricular Aluno";
            this.btnMatricularAluno.UseVisualStyleBackColor = true;
            this.btnMatricularAluno.Click += new System.EventHandler(this.btnMatricularAluno_Click);
            // 
            // btnCadUnidEscolar
            // 
            this.btnCadUnidEscolar.Location = new System.Drawing.Point(663, 516);
            this.btnCadUnidEscolar.Name = "btnCadUnidEscolar";
            this.btnCadUnidEscolar.Size = new System.Drawing.Size(125, 51);
            this.btnCadUnidEscolar.TabIndex = 9;
            this.btnCadUnidEscolar.Text = "Cadastro de Unidades Escolares";
            this.btnCadUnidEscolar.UseVisualStyleBackColor = true;
            this.btnCadUnidEscolar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscaMatricula
            // 
            this.btnBuscaMatricula.Location = new System.Drawing.Point(272, 379);
            this.btnBuscaMatricula.Name = "btnBuscaMatricula";
            this.btnBuscaMatricula.Size = new System.Drawing.Size(124, 44);
            this.btnBuscaMatricula.TabIndex = 10;
            this.btnBuscaMatricula.Text = "Buscar Matrícula";
            this.btnBuscaMatricula.UseVisualStyleBackColor = true;
            this.btnBuscaMatricula.Click += new System.EventHandler(this.btnBuscaMatricula_Click);
            // 
            // btnBuscarUnidade
            // 
            this.btnBuscarUnidade.Location = new System.Drawing.Point(12, 437);
            this.btnBuscarUnidade.Name = "btnBuscarUnidade";
            this.btnBuscarUnidade.Size = new System.Drawing.Size(115, 47);
            this.btnBuscarUnidade.TabIndex = 11;
            this.btnBuscarUnidade.Text = "Buscar Unidade";
            this.btnBuscarUnidade.UseVisualStyleBackColor = true;
            this.btnBuscarUnidade.Click += new System.EventHandler(this.btnBuscarUnidade_Click);
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Location = new System.Drawing.Point(142, 437);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(103, 47);
            this.btnBuscarCurso.TabIndex = 12;
            this.btnBuscarCurso.Text = "Buscar Curso";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // btnRelAlunos
            // 
            this.btnRelAlunos.Location = new System.Drawing.Point(12, 522);
            this.btnRelAlunos.Name = "btnRelAlunos";
            this.btnRelAlunos.Size = new System.Drawing.Size(118, 45);
            this.btnRelAlunos.TabIndex = 13;
            this.btnRelAlunos.Text = "Relatorio Alunos";
            this.btnRelAlunos.UseVisualStyleBackColor = true;
            this.btnRelAlunos.Click += new System.EventHandler(this.btnRelAlunos_Click);
            // 
            // frmBuscarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.btnRelAlunos);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.btnBuscarUnidade);
            this.Controls.Add(this.btnBuscaMatricula);
            this.Controls.Add(this.btnCadUnidEscolar);
            this.Controls.Add(this.btnMatricularAluno);
            this.Controls.Add(this.btnAtualizarAluno);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.txtBuscarAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCurso);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "frmBuscarAluno";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Buscar Aluno ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAddCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.Button btnAtualizarAluno;
        private System.Windows.Forms.Button btnMatricularAluno;
        private System.Windows.Forms.Button btnCadUnidEscolar;
        private System.Windows.Forms.Button btnBuscaMatricula;
        private System.Windows.Forms.Button btnBuscarUnidade;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.Button btnRelAlunos;
    }
}

