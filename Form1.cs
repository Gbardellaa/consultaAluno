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
    public partial class frmBuscarAluno : Form
    {
        public frmBuscarAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    //MessageBox.Show("Conectar ao banco de dados");
                    var sqlQuery = "Select * from aluno";   //sqlQuery - armazena a consulta sql que será executada
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn)) 
                        // sqlDataAdapter - classe usada para preencher o DataTable com os dados do banco
                        // sqlQuery (variável) - armazena a consulta sql que será executada
                        // cn - conexão com o banco 

                    {
                        using (DataTable dt = new DataTable())
                        // DataTable dt = new DataTable - cria uma isntância de DataTable, que é uma tabela em memoria para armazenar os dados recuperados do banco
                        {
                            da.Fill(dt); // Método Fill do sqlDataAdapter executa a consulta SQL (sqlQuery) e preenche a DataTable (dt) c/ resultados da consulta
                            dataGridView1.DataSource = dt; ;
                            // faz com que os dados dos alunos sejam exibidos no dataGridView
                        }
                }    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }
        }
    }
}
