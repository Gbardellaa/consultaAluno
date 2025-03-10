namespace consultaAluno
{
    partial class frmCadUnidEscolar
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
            this.labelCadUnidEscolar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeUnidEscolar = new System.Windows.Forms.TextBox();
            this.txtCidadeUnidEscolar = new System.Windows.Forms.TextBox();
            this.txtEstadoUnidEscolar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCadUnidEscolar
            // 
            this.labelCadUnidEscolar.AutoSize = true;
            this.labelCadUnidEscolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadUnidEscolar.Location = new System.Drawing.Point(233, 74);
            this.labelCadUnidEscolar.Name = "labelCadUnidEscolar";
            this.labelCadUnidEscolar.Size = new System.Drawing.Size(358, 29);
            this.labelCadUnidEscolar.TabIndex = 0;
            this.labelCadUnidEscolar.Text = "Cadastro De Unidade Escolar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Unidade Escolar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade Unidade Escolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado Unidade Escolar";
            // 
            // txtNomeUnidEscolar
            // 
            this.txtNomeUnidEscolar.Location = new System.Drawing.Point(354, 167);
            this.txtNomeUnidEscolar.Name = "txtNomeUnidEscolar";
            this.txtNomeUnidEscolar.Size = new System.Drawing.Size(180, 20);
            this.txtNomeUnidEscolar.TabIndex = 4;
            // 
            // txtCidadeUnidEscolar
            // 
            this.txtCidadeUnidEscolar.Location = new System.Drawing.Point(354, 232);
            this.txtCidadeUnidEscolar.Name = "txtCidadeUnidEscolar";
            this.txtCidadeUnidEscolar.Size = new System.Drawing.Size(180, 20);
            this.txtCidadeUnidEscolar.TabIndex = 5;
            // 
            // txtEstadoUnidEscolar
            // 
            this.txtEstadoUnidEscolar.Location = new System.Drawing.Point(354, 298);
            this.txtEstadoUnidEscolar.Name = "txtEstadoUnidEscolar";
            this.txtEstadoUnidEscolar.Size = new System.Drawing.Size(180, 20);
            this.txtEstadoUnidEscolar.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(311, 354);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(190, 61);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadUnidEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEstadoUnidEscolar);
            this.Controls.Add(this.txtCidadeUnidEscolar);
            this.Controls.Add(this.txtNomeUnidEscolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCadUnidEscolar);
            this.Name = "frmCadUnidEscolar";
            this.Text = "frmCadUnidEscolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadUnidEscolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeUnidEscolar;
        private System.Windows.Forms.TextBox txtCidadeUnidEscolar;
        private System.Windows.Forms.TextBox txtEstadoUnidEscolar;
        private System.Windows.Forms.Button btnSalvar;
    }
}