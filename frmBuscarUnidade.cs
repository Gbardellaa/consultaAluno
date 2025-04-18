﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultaAluno
{
    public partial class frmBuscarUnidade: Form
    {
        public frmBuscarUnidade()
        {
            InitializeComponent();
        }

        private void btnBuscarUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = "Select * from UnidadeEscolar where cidadeUnidadeEscolar like '%" + txtBuscarUnidade.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarUnidade.DataSource = dt;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conctar\n\n" + ex.Message);
            }
        }
    }
}
