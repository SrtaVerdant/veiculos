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
    public partial class Form2 : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=SRTAVERDANT;Initial Catalog=cadastro;Integrated Security=True");
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int retorno;

            ConexaoDB bd = new ConexaoDB();

            if(txtIdFab.Text == "" || txtIdFab.Text == "")
            {
                MessageBox.Show("Campos inválidos");
            }
            else
            {
                int id = Convert.ToInt32(txtIdFab.Text);
                retorno = bd.insertFabricante(id, txtDescFab.Text);
                if (retorno > 0)
                {
                    MessageBox.Show("Cad Efetuado");
                }
                else
                {
                    MessageBox.Show("Deu ruim");
                }
                txtDescFab.Text = "";
                txtIdFab.Text = "";
            }

        }

        private void txtIdFab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnConsultarFab_Click(object sender, EventArgs e)
        {
            ConexaoDB bd = new ConexaoDB();

            int id = Convert.ToInt32(txtIdFab.Text);

            if (txtIdFab.Text == "" || id == 0)
            {
                txtIdFab.Text = "";
                txtDescFab.Text = "";
              
                MessageBox.Show("Campo ID inválido!");
            }
            else
            {
                Fabricante fabricante = null;
                fabricante = bd.getFabricanteById(id);

                if (fabricante == null)
                {
                    txtIdFab.Text = "";
                    txtDescFab.Text = "";
                    MessageBox.Show("Não foi encontrado fabricante com esse ID.");
                }
                else
                {                   
                    txtDescFab.Text = fabricante.Descricao;                
                    
                }

            }
        }

        private void btnEditarFab_Click(object sender, EventArgs e)
        {
            int retorno;
            int id = Convert.ToInt32(txtIdFab.Text);

            if (txtIdFab.Text == "" || id == 0 || txtDescFab.Text == "")
            {
                MessageBox.Show("Campos inválidos");
            }
            else
            {
                ConexaoDB bd = new ConexaoDB();
                Fabricante fabricante = new Fabricante(id, txtDescFab.Text);
                retorno = bd.updateFabricante(fabricante);

                if (retorno > 0)
                {
                    MessageBox.Show("Alteração de fabricante realizada!");
                }
                else
                {
                    MessageBox.Show("Deu ruim");
                }      
                
            }
            txtIdFab.Text = "";
            txtDescFab.Text = "";
        }

        private void btnExcluirFab_Click(object sender, EventArgs e)
        {
            int retorno;
            int id = Convert.ToInt32(txtIdFab.Text);

            if (txtIdFab.Text == "" || id == 0)
            {
                MessageBox.Show("Campos inválidos");
            }
            else
            {
                ConexaoDB bd = new ConexaoDB();
                retorno = bd.deleteFabricante(id);

                if (retorno > 0)
                {
                    MessageBox.Show("Exclusão de fabricante realizada!");
                }
                else
                {
                    MessageBox.Show("Deu ruim");
                }

            }
            txtIdFab.Text = "";
            txtDescFab.Text = "";
        }
    }
}
