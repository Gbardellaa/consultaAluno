using consultaAluno.Relatorios;
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroAluno frm = new frmCadastroAluno(0);
            frm.ShowDialog(); // ShowDialog - Chama a janela Cadastro de aluno
        }

        private void btnAddCurso_Click(object sender, EventArgs e)
        {
    //        frmCadastroCurso frm = new frmCadastroCurso();
    //        frm.ShowDialog();   // ShowDialog - Chama a janela de Cadastro de curso  
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                { cn.Open();
                    //var sqlQuery = "select * from aluno where nomeAluno = '" + txtBuscarAluno.Text + "'";
                    var sqlQuery = "select * from aluno where nomeAluno  like '%"  + txtBuscarAluno.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar \n\n" + ex.Message); 
             } 
        }

        private void btnMatricularAluno_Click(object sender, EventArgs e)
        {
            frmMatricula frm = new frmMatricula();
            frm.ShowDialog();
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        { 
            //Var - Palavra chave do C#  especifica  que o tipo de variável é determinado automaticamente com base no valor atribuido à ela 
            //DataGridView1.CurrentCell.RowIndex - pega o índice da linha atualmente selecionada no DataGridView.
            // dataGridView1.Rows[...].Cells[0].Value - acessa o valor da primeira célula (coluna índice 0) dessa linha. 
            // A linha inteira serve para obter o id do aluno selecionado 
            var idAluno = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            //cria uma nova instância do formulário frmCadastroAluno, passando idAluno como parâmetro para o construtor.
            frmCadastroAluno frm = new frmCadastroAluno(idAluno);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadUnidEscolar frm = new frmCadUnidEscolar();
                frm.ShowDialog();
        }

        private void btnBuscaMatricula_Click(object sender, EventArgs e)
        {
            frmBuscarMatricula frm = new frmBuscarMatricula();
            frm.ShowDialog();   // ShowDialog - Chama a janela de Cadastro de curso  
        }

        private void btnBuscarUnidade_Click(object sender, EventArgs e)
        {
            frmBuscarUnidade frm = new frmBuscarUnidade();
            frm.ShowDialog(); 
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            frmBuscarCurso frm = new frmBuscarCurso();
            frm.ShowDialog();
        }

        private void btnRelAlunos_Click(object sender, EventArgs e)
        {
            frmRelAlunos frm = new frmRelAlunos();
            frm.ShowDialog();
        }
    }
}
