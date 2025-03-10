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
using System.Xml.Serialization;

namespace consultaAluno
{
    public partial class frmMatricula : Form
    {


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        public class ComboboxItem

        {

            public string Text { get; set; } // Armazena o texto visível do item no ComboBox

            public object Value { get; set; } //armazena um valor associado ao item

            public override string ToString() //Retorna a propriedade Text quando o objeto é convertido para string

            // Isso faz  com que o texto coerrteto seja exibido no ComboBox automaticamente  

            {

                return Text;

            }

        }


        private string connectionString = conexao.IniciarCon;

        public frmMatricula()

        {

            InitializeComponent();

            CarregarAlunos();

            CarregarCursos();

            CarregarUnidadeEscolar();

        }


        private void CarregarAlunos() //Declaração do Método CarregarAlunos

        {

            using (SqlConnection cn = new SqlConnection(connectionString)) //Criando a Conexão com o banco de dados

            {

                cn.Open(); // Abrindo conexão com Banco

                SqlCommand cmd = new SqlCommand("select idAluno, nomeAluno from aluno", cn); //Criando e Executando o Comando SQL

                SqlDataReader reader = cmd.ExecuteReader(); //Executando a Leitura dos Dados

                while (reader.Read()) //Lendo os Dados e Adicionando ao ComboBox

                {

                    cmbNomeAluno.Items.Add(new ComboboxItem

                    {

                        Text = reader["nomeAluno"].ToString(),

                        Value = reader["idAluno"]

                    });

                }

            }

        }

        private void CarregarCursos()

        {

            using (SqlConnection cn = new SqlConnection(connectionString))

            {

                cn.Open();

                SqlCommand cmd = new SqlCommand("Select idCurso, nomeCurso from cursos", cn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())

                {

                    cmbNomeCurso.Items.Add(new ComboboxItem

                    {

                        Text = reader["nomeCurso"].ToString(),

                        Value = reader["idCurso"]

                    });

                }

            }

        }

        private void CarregarUnidadeEscolar()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))

            {

                cn.Open();

                SqlCommand cmd = new SqlCommand("Select idUnidadeEscolar, nomeUnidadeEscolar from UnidadeEscolar", cn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())

                {

                    cmbUnidadeEscolar.Items.Add(new ComboboxItem

                    {

                        Text = reader["nomeUnidadeEscolar"].ToString(),

                        Value = reader["idUnidadeEscolar"]

                    });

                }

            }

        }



        private void btnSalvar_Click(object sender, EventArgs e)

        {

            if (cmbNomeAluno.SelectedItem == null || cmbNomeCurso.SelectedItem == null)

            {

                MessageBox.Show("Selecione um Aluno e um Curso");

                return;

            }

            int idAluno = (int)(cmbNomeAluno.SelectedItem as ComboboxItem).Value;

            int idCurso = (int)(cmbNomeCurso.SelectedItem as ComboboxItem).Value;

            DateTime dataMatricula = dtpDataMatricula.Value;

            string statusMatricula = cmbStatusMatricula.SelectedItem.ToString();

            using (SqlConnection cn = new SqlConnection(connectionString))

            {

                cn.Open();

                SqlCommand cmd = new SqlCommand("Insert into matriculas (idAluno, idCurso, dataMatricula, statusMatricula) VALUES (@idAluno, @idCurso, @dataMatricula, @statusMatricula)", cn);

                cmd.Parameters.AddWithValue("@idAluno", idAluno);

                cmd.Parameters.AddWithValue("@idCurso", idCurso);

                cmd.Parameters.AddWithValue("@dataMatricula", dataMatricula);

                cmd.Parameters.AddWithValue("@statusMatricula", statusMatricula);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Matricula realizada com sucesso!");
            }
        }
    }
}





