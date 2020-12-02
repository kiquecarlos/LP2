using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PF_0030482013005
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmCidade"];

            if (fc != null)
            {
                fc.Close();
            }

            frmCidade frmC = new frmCidade();
            frmC.MdiParent = this;
            frmC.WindowState = FormWindowState.Maximized;
            frmC.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            { // aqui a conexão vai depende da sua máquina da escola ou particular
                conexao = new SqlConnection(@"Data Source=Choliveira\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True;Pooling=False");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex) { MessageBox.Show("Outros Erros =/" + ex.Message); }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["AboutBox1"];

            if (fc != null)
            {
                fc.Close();
            }

            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }
    }
}