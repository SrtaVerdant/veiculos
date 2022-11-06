using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    internal class ConexaoDB {
        SqlConnection conexao = new SqlConnection("Data Source=SRTAVERDANT;Initial Catalog=cadastro;Integrated Security=True");
        SqlCommand comando;
        string sql;
        int retorno;
        SqlDataAdapter da;
        SqlDataReader dr;

        public int insertFabricante(int id, String descricao)
        {
            try
            {
                conexao.Open();
                sql = "insert into Fabricantes (ID, descricao) values ( " + id + ", '" + descricao + "')";
                comando = new SqlCommand(sql, conexao);
                retorno = comando.ExecuteNonQuery();                            
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }

            return retorno;
        }


        public List<Fabricante> getAllFabricantes()
        {
            Fabricante fabricante;
            List<Fabricante> lista = new List<Fabricante>();
            try
            {   
               
                conexao.Open();
                sql = "select * from fabricantes";
                comando = new SqlCommand(sql, conexao);
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    fabricante = new Fabricante(Convert.ToInt32(dr["id"].ToString()), dr["descricao"].ToString());    
                    lista.Add(fabricante);
                }
                comando.Dispose();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }

            return lista;

        }

        public int insertVeiculo(Veiculos veiculo)
        {
            Veiculos veiculo1 = null;
            ConexaoDB conexaoDB = new ConexaoDB();
            veiculo1 = conexaoDB.getVeiculoById(veiculo.Id);

            if (veiculo1 == null)
            {
                retorno = 10;
            }
            else
            {
                try
                {
                    conexao.Open();
                    sql = "insert into Veiculos ( Id, Modelo, Ano, Preco, ID_Fabricante) values ( " + veiculo.Id + ", '"
                        + veiculo.Modelo + "', '" + veiculo.Ano + "', '" + veiculo.Preco+"','" + veiculo.Fabricante.Id + "')";
                    comando = new SqlCommand(sql, conexao);
                    retorno = comando.ExecuteNonQuery();
                    comando.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex.Message);
                }
            }
            return retorno;
        }

        public Veiculos getVeiculoById(int id)
        {
            Veiculos veiculo = null;
            Fabricante fabricante2;
            try
            {
                conexao.Open();
                sql = "select * from Veiculos where id = " + id;
                comando = new SqlCommand(sql, conexao);
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    ConexaoDB conexaoDB = new ConexaoDB();
                    Fabricante fabricante = conexaoDB.getFabricanteById(Convert.ToInt32(dr["ID_Fabricante"].ToString()));
                    fabricante2 = new Fabricante(fabricante.Id, fabricante.Descricao);
                    veiculo = new Veiculos(Convert.ToInt32(dr["id"].ToString()), dr["Modelo"].ToString(), Convert.ToInt32(dr["ano"].ToString()), Convert.ToDouble(dr["preco"].ToString()), fabricante2);                  
             
                }
                comando.Dispose();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }

            return veiculo;
        }

        public Fabricante getFabricanteById(int id)
        {            
            Fabricante fabricante = null;
            try
            {
                conexao.Open();
                sql = "select * from Fabricantes where id = " + id;
                comando = new SqlCommand(sql, conexao);
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    fabricante = new Fabricante(Convert.ToInt32(dr["Id"].ToString()), dr["descricao"].ToString());
                }               
 
                comando.Dispose();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }

            return fabricante;
        }

        public int updateVeiculo(Veiculos veiculo)
        {
            try
            {
                conexao.Open();
                sql = "update Veiculos set Modelo='" + veiculo.Modelo + "',Ano='" + veiculo.Ano + "', Preco='"
                    + veiculo.Preco + "', ID_Fabricante='" + veiculo.Fabricante.Id + "' where id=" + veiculo.Id;
                comando = new SqlCommand(sql, conexao);
                retorno = comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            
            return retorno;
        }

        public int deleteVeiculo(int id)
        {
            try
            {
                conexao.Open();
                sql = "delete Veiculos where id = " + id;
                comando = new SqlCommand(sql, conexao);
                retorno = comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }

            return retorno;
        }

        public int updateFabricante(Fabricante fabricante)
        {
            try
            {
                conexao.Open();
                sql = "update Fabricantes set Descricao='" + fabricante.Descricao + "' where id=" + fabricante.Id;
                comando = new SqlCommand(sql, conexao);
                retorno = comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }

            return retorno;
        }
    }
}
