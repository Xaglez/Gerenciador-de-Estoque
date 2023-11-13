using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_estoque
{
    public partial class F_Principal : Form
    {
  
        public static F_login inicio;
        public F_Principal()
        {           
            InitializeComponent();                                
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;          
            GetHora(lb_hora);
            p_central.Controls.Clear();
            lb_data.Text = DateTime.Today.ToShortDateString();
            lb_setCargo.Text = Globais.cargo;
            lb_setUsuario.Text = Globais.nome_usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globais.nome_usuario = null;
            Globais.cargo = null;
            Globais.logado = false;
            Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            F_Estoque f_Estoque = new F_Estoque();
            AbrirPainel(f_Estoque);
        }

        private void GetHora(Label label)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;

            timer.Tick += (sender, e) =>
            {
                label.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            timer.Start();
        }
        private void AbrirPainel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            p_central.Controls.Clear();
            p_central.Controls.Add(form);
            form.BackColor = SystemColors.Control;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }   

        private void btn_vender_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            p_central.Controls.Clear();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
                       
            F_Clientes f_Clientes = new F_Clientes();
            AbrirPainel(f_Clientes);
  
        }

        private void btn_tarefas_Click(object sender, EventArgs e)
        {

            F_Cadastro f_Tarefas = new F_Cadastro();
            AbrirPainel(f_Tarefas);
           
        }
    }
}
