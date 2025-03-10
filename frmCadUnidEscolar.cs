using System;
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
    public partial class frmCadUnidEscolar: Form
    {
        public frmCadUnidEscolar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "Insert Into UnidadeEscolar (nomeUnidadeEscolar, cidadeUnidadeEscolar,estadoUnidadeEscolar) values (@nomeU, @cidadeU, @estadoU)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nomeU", txtNomeUnidEscolar.Text);
                        cmd.Parameters.AddWithValue("@cidadeU", txtCidadeUnidEscolar.Text);
                        cmd.Parameters.AddWithValue("@estadoU", txtEstadoUnidEscolar.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Salvo Com Sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não Salvos.\n\n" + ex.Message);
            }
        }
    }
}
