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
                tratarRetorno(retorno);
            }
            limpaCampos();

        }

        

        private void btnConsultarFab_Click(object sender, EventArgs e)
        {
            ConexaoDB bd = new ConexaoDB();            

            if (txtIdFab.Text == "" || Convert.ToInt32(txtIdFab.Text) == 0)
            {
                limpaCampos();

                MessageBox.Show("Campo ID inválido!");
            }
            else
            {
                int id = Convert.ToInt32(txtIdFab.Text);
                Fabricante fabricante = null;
                fabricante = bd.getFabricanteById(id);

                if (fabricante == null)
                {
                    limpaCampos();
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
            

            if (txtIdFab.Text == "" || Convert.ToInt32(txtIdFab.Text) == 0 || txtDescFab.Text == "")
            {
                limpaCampos();
                MessageBox.Show("Campos inválidos");
            }
            else
            {
                int id = Convert.ToInt32(txtIdFab.Text);
                ConexaoDB bd = new ConexaoDB();
                Fabricante fabricante = new Fabricante(id, txtDescFab.Text);
                retorno = bd.updateFabricante(fabricante);

                tratarRetorno(retorno);
            }
            limpaCampos();
        }

        private void btnExcluirFab_Click(object sender, EventArgs e)
        {
            int retorno;
           

            if (txtIdFab.Text == "" || Convert.ToInt32(txtIdFab.Text) == 0)
            {
                MessageBox.Show("Campos inválidos");
            }
            else
            {
                int id = Convert.ToInt32(txtIdFab.Text);
                ConexaoDB bd = new ConexaoDB();
                retorno = bd.deleteFabricante(id);

                tratarRetorno(retorno);

            }
            limpaCampos();
        }

        private void txtIdFab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        public void limpaCampos()
        {
            txtIdFab.Text = "";
            txtDescFab.Text = "";
        }

        private void tratarRetorno(int retorno)
        {
            if (retorno > 0)
            {
                MessageBox.Show("Operação realizada!");
            }
            else
            {
                MessageBox.Show("Erro! \nTente novamente");
            }
        }
    }
}
