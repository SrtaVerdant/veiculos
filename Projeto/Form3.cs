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

            foreach(Fabricante fabricante in lista)
            {
                selectFabricante.Items.Add(fabricante.Id + " - " + fabricante.Descricao);
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(selectFabricante.SelectedItem.ToString());
        }

        private void btnInserirVeiculo_Click(object sender, EventArgs e)
        {
            int retorno;

            ConexaoDB bd = new ConexaoDB();

            if (txtCodVeiculo.Text == "" || txtAnoVeiculo.Text == "" || txtModVeiculo.Text == "" || txtPrecoVeiculo.Text == "")
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
        
                retorno = bd.insertVeiculo(veiculo);
                if (retorno == 10)
                {
                    MessageBox.Show("Não é possivel cadastrar o veiculo com o ID informado, tente novamente!");
                }else if (retorno > 0)
                {
                    MessageBox.Show("Cad Efetuado");
                }
                else
                {
                    MessageBox.Show("Deu ruim");
                }
                txtCodVeiculo.Text = "";
                txtAnoVeiculo.Text = "";
                txtModVeiculo.Text = "";
                txtPrecoVeiculo.Text = "";
            }
        }

        private void btnConsultarVeiculo_Click(object sender, EventArgs e)
        {
            ConexaoDB bd = new ConexaoDB();

            int id = Convert.ToInt32(txtCodVeiculo.Text);

            if (txtCodVeiculo.Text == "" || id == 0)
            {
                txtCodVeiculo.Text = "";
                txtModVeiculo.Text = "";
                txtAnoVeiculo.Text = "";
                txtPrecoVeiculo.Text = "";
                selectFabricante.SelectedIndex = 0;
                MessageBox.Show("Campo ID inválido!");
            }
            else
            {               
                Veiculos veiculo = null;
                veiculo = bd.getVeiculoById(id);

                if (veiculo == null)
                {
                    txtCodVeiculo.Text = "";
                    txtModVeiculo.Text = "";
                    txtAnoVeiculo.Text = "";
                    txtPrecoVeiculo.Text = "";
                    selectFabricante.SelectedIndex = 0;
                    MessageBox.Show("Não foi encontrado veículo com esse ID.");
                }               
                else
                {
                    
                    txtModVeiculo.Text = veiculo.Modelo;
                    txtAnoVeiculo.Text = veiculo.Ano.ToString();
                    txtPrecoVeiculo.Text = veiculo.Preco.ToString();
                    Console.WriteLine(veiculo.Fabricante.Id + " - " + veiculo.Fabricante.Descricao);
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
                    else {
                        
                    }
                   
                }
               
            }
        }

        private void txtAnoVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
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

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            int retorno;

            ConexaoDB bd = new ConexaoDB();

            if (txtCodVeiculo.Text == "" || txtAnoVeiculo.Text == "" || txtModVeiculo.Text == "" || txtPrecoVeiculo.Text == "")
            {
                MessageBox.Show("Campos inválidos");
            }
            else
            {
                String selectFab = selectFabricante.SelectedItem.ToString();
                string[] s = selectFab.Split('-');
                Fabricante fabricante = new Fabricante(Convert.ToInt32(s[0]), s[1]);

                int id = Convert.ToInt32(txtCodVeiculo.Text);
                int ano = Convert.ToInt32(txtAnoVeiculo.Text);
                Double preco = Convert.ToDouble(txtPrecoVeiculo.Text);
                Veiculos veiculo = new Veiculos(id, txtModVeiculo.Text, ano, preco, fabricante);

                retorno = bd.updateVeiculo(veiculo);

                if (retorno > 0)
                {
                    MessageBox.Show("Alteração de veiculo realizada!");
                }
                else
                {
                    MessageBox.Show("Deu ruim");
                }
                txtCodVeiculo.Text = "";
                txtAnoVeiculo.Text = "";
                txtModVeiculo.Text = "";
                txtPrecoVeiculo.Text = "";
                selectFabricante.SelectedIndex = 0;
            }
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            int retorno;

            ConexaoDB bd = new ConexaoDB();

            int id = Convert.ToInt32(txtCodVeiculo.Text);

            if (txtCodVeiculo.Text == "" || id == 0)
            {
                MessageBox.Show("Campo ID inválido");
            }
            else
            {                    
                 retorno = bd.deleteVeiculo(id);

                if (retorno > 0)
                {
                    MessageBox.Show("Exclusão de veiculo realizada!");
                }
                else
                {
                    MessageBox.Show("Deu ruim");
                }
                txtCodVeiculo.Text = "";
                txtAnoVeiculo.Text = "";
                txtModVeiculo.Text = "";
                txtPrecoVeiculo.Text = "";
                selectFabricante.SelectedIndex = 0;
            }
        }
    }
}
