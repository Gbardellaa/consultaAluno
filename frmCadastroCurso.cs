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
    public partial class frmCadastroCurso : Form
    {
        public frmCadastroCurso(int idCurso)
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon)) //Cria uma nova conexão com banco
                {
                    cn.Open(); //Abre a conexão com banco de dados. Sem isso não é possível executar comandos SQL
                    //Define a consulta SQL que será executada
                    var sql = "INSERT INTO cursos (nomeCurso, descricaoCurso, dataInicioCurso, dataFimCurso, cargaHorariaCurso, statusCurso) VALUES (@nomeC, @descricaoC, @dataInicioC, @dataFimC, @cargaHorariaC, @statusC)";
                    // Cria um objeto SqlCommand que representa o comando SQl a ser executado.
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        //Adiciona os valores de parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles do formulário (txtNome.txt, txtData.txt, etc).
                        
                        cmd.Parameters.AddWithValue("@nomeC", txtNomeCurso.Text);
                        cmd.Parameters.AddWithValue("@descricaoC",txtDescricaoCurso.Text);
                        cmd.Parameters.AddWithValue("@dataInicioC",txtDataInicioCurso.Text);
                        cmd.Parameters.AddWithValue("@dataFimC",txtDataFimCurso.Text);
                        cmd.Parameters.AddWithValue("@cargaHorariaC",txtcargaHorariaCurso.Text);
                        cmd.Parameters.AddWithValue("@statusC",txtStatusCurso.Text);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
