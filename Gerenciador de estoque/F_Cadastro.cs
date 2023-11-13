using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gerenciador_de_estoque
{
    public partial class F_Cadastro : Form
    {
        string sql;

        public F_Cadastro()
        {
            InitializeComponent();
        }

        private void F_Cadastro_Load(object sender, EventArgs e)
        {
            //dgv_consulta.DataSource = Banco.ObterTodosUsuarios();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tb_idPesquisa.Text))
            {
                string id = tb_idPesquisa.Text;
                sql = "SELECT * FROM tb_usuarios WHERE ID_Usuario ='" + id + "'";
                // dgv_consulta.DataSource = Banco.Consulta(sql);
                tb_idPesquisa.Text = "";
                if (dgv_consulta.Rows.Count < 2)
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Insira algum filtro de busca");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // dgv_consulta.DataSource = Banco.ObterTodosUsuarios();
        }

        private void dgv_consulta_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                DataGridViewRow row = dgv_consulta.Rows[e.Cell.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    tb_id.Text = row.Cells[0].Value.ToString();
                    tb_nome.Text = row.Cells[1].Value.ToString();
                    tb_username.Text = row.Cells[2].Value.ToString();
                    tb_senha.Text = row.Cells[3].Value.ToString();
                    cb_status.Text = row.Cells[4].Value.ToString();
                    tb_cargo.Text = row.Cells[5].Value.ToString();
                    tb_telefone.Text = row.Cells[7].Value.ToString();
                    tb_endereço.Text = row.Cells[8].Value.ToString();
                    tb_cargaHoraria.Text = row.Cells[9].Value.ToString();
                    tb_dataInicio.Text = row.Cells[10].Value.ToString();

                    if (decimal.TryParse(row.Cells[6].Value?.ToString(), out decimal nivel))
                    {
                        n_nivel.Value = nivel;
                    }
                }
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = tb_nome.Text;
            usuario.username = tb_username.Text;
            usuario.senha = tb_senha.Text;
            usuario.status = cb_status.Text;
            usuario.cargo = tb_cargo.Text;
            usuario.telefone = tb_telefone.Text;
            usuario.endereco = tb_endereço.Text;
            usuario.cargaHoraria = tb_cargaHoraria.Text;
            usuario.dataInicio = tb_dataInicio.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(n_nivel.Value, 0));

            //Banco.NovoUsuario(usuario);
            //dgv_consulta.DataSource = Banco.ObterTodosUsuarios();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.id = Convert.ToInt32(tb_id.Text);
            usuario.nome = tb_nome.Text;
            usuario.username = tb_username.Text;
            usuario.senha = tb_senha.Text;
            usuario.status = cb_status.Text;
            usuario.cargo = tb_cargo.Text;
            usuario.telefone = tb_telefone.Text;
            usuario.endereco = tb_endereço.Text;
            usuario.cargaHoraria = tb_cargaHoraria.Text;
            usuario.dataInicio = tb_dataInicio.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(n_nivel.Value, 0));

            //Banco.Salvar(usuario);
            //dgv_consulta.DataSource = Banco.ObterTodosUsuarios();
            
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.id = Convert.ToInt32(tb_id.Text);
            usuario.nome = tb_nome.Text;
            usuario.username = tb_username.Text;
            usuario.senha = tb_senha.Text;
            usuario.status = cb_status.Text;
            usuario.cargo = tb_cargo.Text;
            usuario.telefone = tb_telefone.Text;
            usuario.endereco = tb_endereço.Text;
            usuario.cargaHoraria = tb_cargaHoraria.Text;
            usuario.dataInicio = tb_dataInicio.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(n_nivel.Value, 0));

           // Banco.Remover(usuario);
           // dgv_consulta.DataSource = Banco.ObterTodosUsuarios();
        }
    }
}
