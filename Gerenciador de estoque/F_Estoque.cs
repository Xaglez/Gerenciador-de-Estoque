using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_estoque
{
    public partial class F_Estoque : Form
    {
        public F_Estoque()
        {
            InitializeComponent();          
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string escolha = cb_filtro.SelectedItem.ToString();
            string pesquisa = tb_pesquisa.Text;
            string filtro = "";

            switch (escolha)
            {
                case "Tipo de Produto":
                    filtro = "Tipo de Produto";
                    break;

                case "Produto":
                    filtro = "Produto";
                    break;

                case "Fornecedor":
                    filtro = "Fornecedor";
                    break;

                case "Todos":
                    string sql = "SELECT * FROM tb_produtos";
                    //dgv_estoque.DataSource = Banco.Consulta(sql);
                    return;
            }

            Pesquisa(filtro, pesquisa);
        }

        private void Pesquisa(string filtro, string pesquisa)
        {
            string sql = "SELECT * FROM tb_produtos WHERE " + filtro + " LIKE '%" + pesquisa + "%'";

            if (!String.IsNullOrEmpty(filtro) && !String.IsNullOrEmpty(pesquisa))
            {
                //dgv_estoque.DataSource = Banco.Consulta(sql);
                tb_pesquisa.Text = "";

                //if (dgv_estoque.Rows.Count < 1)
                //{
                //    MessageBox.Show("Produto não encontrado");
                //}
            }
            else
            {
                MessageBox.Show("Insira algum filtro");
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void F_Estoque_Load(object sender, EventArgs e)
        {
           // dgv_estoque.DataSource =  Banco.ObterTodosProdutos();
        }

        private void tb_precoDeCompra_MultilineChanged(object sender, EventArgs e)
        {
           
        }

        private void dgv_estoque_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                //DataGridViewRow row = dgv_estoque.Rows[e.Cell.RowIndex];
                //if (row.Cells[0].Value != null)
                //{
                //    tb_id.Text = row.Cells[0].Value.ToString();
                //    tb_tipoDeProduto.Text = row.Cells[1].Value.ToString();
                //    tb_produto.Text = row.Cells[2].Value.ToString();
                //    tb_quantidade.Text = row.Cells[3].Value.ToString();
                //    tb_preco.Text = row.Cells[4].Value.ToString();
                //    mtb_dataDeCompra.Text = row.Cells[5].Value.ToString();
                //    tb_fornecedor.Text = row.Cells[6].Value.ToString();
                //    tb_precoDeCompra.Text = row.Cells[7].Value.ToString();

                //}
            }
        }      
    }
}
