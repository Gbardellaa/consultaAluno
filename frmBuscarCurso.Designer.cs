namespace consultaAluno
{
    partial class frmBuscarCurso
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
            this.txtBuscarCurso = new System.Windows.Forms.TextBox();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.dgvBuscarCurso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Curso ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso";
            // 
            // txtBuscarCurso
            // 
            this.txtBuscarCurso.Location = new System.Drawing.Point(112, 103);
            this.txtBuscarCurso.Name = "txtBuscarCurso";
            this.txtBuscarCurso.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarCurso.TabIndex = 2;
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCurso.Location = new System.Drawing.Point(315, 98);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(90, 31);
            this.btnBuscarCurso.TabIndex = 3;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // dgvBuscarCurso
            // 
            this.dgvBuscarCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCurso.Location = new System.Drawing.Point(33, 143);
            this.dgvBuscarCurso.Name = "dgvBuscarCurso";
            this.dgvBuscarCurso.Size = new System.Drawing.Size(733, 272);
            this.dgvBuscarCurso.TabIndex = 4;
            // 
            // frmBuscarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBuscarCurso);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.txtBuscarCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarCurso";
            this.Text = "frmBuscarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarCurso;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.DataGridView dgvBuscarCurso;
    }
}