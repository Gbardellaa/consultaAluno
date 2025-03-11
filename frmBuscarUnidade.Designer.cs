namespace consultaAluno
{
    partial class frmBuscarUnidade
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBuscarUnidade = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarUnidade = new System.Windows.Forms.TextBox();
            this.btnBuscarUnidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarUnidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Unidade";
            // 
            // dgvBuscarUnidade
            // 
            this.dgvBuscarUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarUnidade.Location = new System.Drawing.Point(12, 108);
            this.dgvBuscarUnidade.Name = "dgvBuscarUnidade";
            this.dgvBuscarUnidade.Size = new System.Drawing.Size(751, 312);
            this.dgvBuscarUnidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unidade";
            // 
            // txtBuscarUnidade
            // 
            this.txtBuscarUnidade.Location = new System.Drawing.Point(130, 66);
            this.txtBuscarUnidade.Name = "txtBuscarUnidade";
            this.txtBuscarUnidade.Size = new System.Drawing.Size(209, 20);
            this.txtBuscarUnidade.TabIndex = 4;
            // 
            // btnBuscarUnidade
            // 
            this.btnBuscarUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUnidade.Location = new System.Drawing.Point(355, 61);
            this.btnBuscarUnidade.Name = "btnBuscarUnidade";
            this.btnBuscarUnidade.Size = new System.Drawing.Size(91, 41);
            this.btnBuscarUnidade.TabIndex = 5;
            this.btnBuscarUnidade.Text = "Buscar";
            this.btnBuscarUnidade.UseVisualStyleBackColor = true;
            this.btnBuscarUnidade.Click += new System.EventHandler(this.btnBuscarUnidade_Click);
            // 
            // frmBuscarUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarUnidade);
            this.Controls.Add(this.txtBuscarUnidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarUnidade);
            this.Controls.Add(this.label2);
            this.Name = "frmBuscarUnidade";
            this.Text = "frmBuscarUnidade";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarUnidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBuscarUnidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarUnidade;
        private System.Windows.Forms.Button btnBuscarUnidade;
    }
}