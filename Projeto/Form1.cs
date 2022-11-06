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

namespace Projeto
{
    public partial class Form1 : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=SRTAVERDANT;Initial Catalog=cadastro;Integrated Security=True");
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;
        public Form1()
        {
            InitializeComponent();
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2;
            frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3;
            frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
