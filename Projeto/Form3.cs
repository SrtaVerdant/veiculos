using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Projeto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ConexaoDB db = new ConexaoDB();


            List<Fabricante> lista = new List<Fabricante>();
            lista = db.getAllFabricantes();

            if(lista.Count == 0)
            {
                btnAlterarVeiculo.Enabled = false;
                btnConsultarVeiculo.Enabled = false;
                btnExcluirVeiculo.Enabled = false;
                btnInserirVeiculo.Enabled = false;

                MessageBox.Show("Adicione primeiro um Fabricante");
            }
            else
            {
                foreach (Fabricante fabricante in lista)
                {
                    selectFabricante.Items.Add(fabricante.Id + " - " + fabricante.Descricao);
                }
            }            
        }

        private void btnInserirVeiculo_Click(object sender, EventArgs e)
        {
            int retorno;            

            if (txtCodVeiculo.Text == "" || Convert.ToInt32(txtCodVeiculo.Text) == 0 || txtAnoVeiculo.Text == "" || txtModVeiculo.Text == "" || txtPrecoVeiculo.Text == "")
            {
                MessageBox.Show("Campos inválidos");
            }
            else
            {
                String selectFab = selectFabricante.SelectedItem.ToString();
                string[] s = selectFab.Split('-');
                Fabricante fabricante = new Fabricante(Convert.ToInt32(s[0].Trim()), s[1]);

                int id = Convert.ToInt32(txtCodVeiculo.Text);
                int ano = Convert.ToInt32(txtAnoVeiculo.Text);
                Double preco = Convert.ToDouble(txtPrecoVeiculo.Text);
                Veiculos veiculo = new Veiculos(id, txtModVeiculo.Text, ano, preco, fabricante);

                ConexaoDB bd = new ConexaoDB();
                retorno = bd.insertVeiculo(veiculo);

                tratarRetorno(retorno);
                limpaCampos();
            }
        }

        private void btnConsultarVeiculo_Click(object sender, EventArgs e)
        {
            if (txtCodVeiculo.Text == "" || Convert.ToInt32(txtCodVeiculo.Text) == 0)
            {
                limpaCampos();
                MessageBox.Show("Campo ID inválido!");
            }
            else
            {
                ConexaoDB bd = new ConexaoDB();
                int id = Convert.ToInt32(txtCodVeiculo.Text);

                Veiculos veiculo = null;
                veiculo = bd.getVeiculoById(id);

                if (veiculo == null)
                {
                    limpaCampos();
                    MessageBox.Show("Não foi encontrado veículo com esse ID.");
                }               
                else
                {                    
                    txtModVeiculo.Text = veiculo.Modelo;
                    txtAnoVeiculo.Text = veiculo.Ano.ToString();
                    txtPrecoVeiculo.Text = veiculo.Preco.ToString();
                    if (selectFabricante.Items.Contains(veiculo.Fabricante.Id + " - " + veiculo.Fabricante.Descricao))
                    {
                        int cont = 0;
                        foreach(var item in selectFabricante.Items)
                        {  
                            if(item.ToString().Equals(veiculo.Fabricante.Id + " - " + veiculo.Fabricante.Descricao)){
                                break;
                            }
                            cont++;
                        }
                        selectFabricante.SelectedIndex = cont;
                    }                    
                   
                }
               
            }
        }       

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            int retorno;            

            if (txtCodVeiculo.Text == "" || txtAnoVeiculo.Text == "" || txtModVeiculo.Text == "" || txtPrecoVeiculo.Text == "")
            {
                MessageBox.Show("Campos inválidos");
            }
            else
            {
                ConexaoDB bd = new ConexaoDB();
                String selectFab = selectFabricante.SelectedItem.ToString();
                string[] s = selectFab.Split('-');
                Fabricante fabricante = new Fabricante(Convert.ToInt32(s[0]), s[1]);

                int id = Convert.ToInt32(txtCodVeiculo.Text);
                int ano = Convert.ToInt32(txtAnoVeiculo.Text);
                Double preco = Convert.ToDouble(txtPrecoVeiculo.Text);
                Veiculos veiculo = new Veiculos(id, txtModVeiculo.Text, ano, preco, fabricante);

                retorno = bd.updateVeiculo(veiculo);

                tratarRetorno(retorno);
                limpaCampos();
            }
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            int retorno;            

            if (txtCodVeiculo.Text == "" || Convert.ToInt32(txtCodVeiculo.Text) == 0)
            {
                MessageBox.Show("Campo ID inválido");
            }
            else
            {
                int id = Convert.ToInt32(txtCodVeiculo.Text);

                ConexaoDB bd = new ConexaoDB();                
                retorno = bd.deleteVeiculo(id);

                tratarRetorno(retorno);
                limpaCampos();
            }
        }

        private void txtAnoVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecoVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        public void limpaCampos()
        {
            txtCodVeiculo.Text = "";
            txtAnoVeiculo.Text = "";
            txtModVeiculo.Text = "";
            txtPrecoVeiculo.Text = "";
            selectFabricante.SelectedIndex = 0;
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
