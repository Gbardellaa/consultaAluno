using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultaAluno
{
    public partial class frmCadastroAluno : Form
    {
        int idAluno = 0;
        public frmCadastroAluno(int idAluno)
        {
            InitializeComponent();
            this.idAluno = idAluno;

            if (this.idAluno > 0)
                GetAluno(idAluno);
        }

        public frmCadastroAluno()
        {
        }

        private void GetAluno(int idAluno)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "Select * from aluno where idAluno=" + idAluno;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNome.Text = dr["nomeAluno"].ToString();
                                    txtDtNascAluno.Text = dr["datNascAluno"].ToString();
                                    txtEmail.Text = dr["emailAluno"].ToString();
                                    txtTelefone.Text = dr["telAluno"].ToString();
                                    txtAnoAluno.Text = dr["anoAluno"].ToString();
                                }
                            }
                        } 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não atualizado .\n\n" + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Os blocos try e catch são usados para tratamento de exceções, ou seja, para lidar com erros que podem ocorrer durante a execução do código.
            try
            {
                using(SqlConnection cn = new SqlConnection(conexao.IniciarCon)) //Cria uma nova conexão com banco
                { 
                        cn.Open(); //Abre a conexão com banco de dados. Sem isso não é possível executar comandos SQL
                    //Define a consulta SQL que será executada
                    var sql = "INSERT INTO aluno (nomeAluno , datNascAluno, emailAluno, telAluno, anoAluno) VALUES (@nome, @data, @email, @tel, @ano)";
                    // Cria um objeto SqlCommand que representa o comando SQl a ser executado.
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        //Adiciona os valores de parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles do formulário (txtNome.txt, txtData.txt, etc).
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@data", txtDtNascAluno.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@ano", txtAnoAluno.Text);
                        cmd.ExecuteNonQuery(); // Executa o comando SQL no banco de dados

                        MessageBox.Show("Salvo com sucesso"); // Se o comando SQL for executado com sucesso, uma mensagem é exibida ao usuário
                    }



                }
            }
            //Se ocorrer algum erro durante a execução do código no bloco try, o controle será passado para o bloco catch.
            catch (Exception ex) //Exception ex: Captura a exceção gerada.
            {
                MessageBox.Show("Dados não salvos.\n\n" + ex.Message); //Exibe uma mensagem de erro ao usuário, incluindo a mensagem da exceção (ex.Message).  
            }
              
        }
    }
}
