﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultaAluno
{
    public partial class frmBuscarCurso : Form
    {
        public frmBuscarCurso()
        {
            InitializeComponent();
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "Select * from cursos where nomeCurso like '%" + txtBuscarCurso.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarCurso.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conctar\n\n" + ex.Message);
            }
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvBuscarCurso.SelectedRows.Count > 0)
            {
                // Pega o idAluno da linha selecionada
                int idCurso = Convert.ToInt32(dgvBuscarCurso.SelectedRows[0].Cells["idCurso"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir este curso?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM curso WHERE idCurso = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idCurso);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Curso excluído com sucesso!");
                                BuscarNovamente(); // Recarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir curso.\n\n" + ex.Message);
                    }
                }
            }
        }
        private void BuscarNovamente()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "select * from alunos where nomeAluno like '%" + txtBuscarCurso.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarCurso.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados.\n\n" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (dgvBuscarCurso.SelectedRows.Count > 0)
            {
                // Pega o ID do aluno selecionado
                int idCurso = Convert.ToInt32(dgvBuscarCurso.SelectedRows[0].Cells["idCurso"].Value);

                // Abre o formulário de cadastro com os dados do curso
                frmCadastroCurso frm = new frmCadastroCurso(idCurso);
                frm.ShowDialog();

                // Atualiza a lista após edição
                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um curso para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

    
          

        
    
    

