using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balcao
{
    class ConexaoDB
    {
        //string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\BancodeDados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";

        string conexaoString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =  \\MAINSERVIDOR-PC\Arquivos Sistema Valendo\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";

        #region Variaveis da Classe
        public object codigo;
        //public object valorVenda;
        //public object valorPromocao;
        public object nome;
        public object categoria;
        public object codBarra;

        public object barControle;
        public object barData;
        public object barHora;
        public object barCodigoBarra;
        public object barValor;
        public object barPeso;
        public object barBipado;
        #endregion

        public void BuscarDadosProdutos(int x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Produtos where Codigo= '" + x + "';";
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Codigo"] != null)
                    {
                        codigo = reader["Codigo"].ToString();
                        nome = reader["Descricao"].ToString();
                        categoria = reader["Categoria"].ToString();

                    }

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }

        }
        public void BuscarDadosProdutosRef(string x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Produtos where Referencia= '" + x + "';";
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Codigo"] != null)
                    {
                        codigo = reader["Codigo"].ToString();
                        nome = reader["Descricao"].ToString();
                        categoria = reader["Categoria"].ToString();
                    }

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }

        }
        public void BuscarDadosProdutosCodigoRef(string x)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Prod_Codigo where referencia = '" + x + "';";
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Codigo"] != null)
                    {
                        codigo = reader["Codigo"].ToString();
                        nome = reader["descriçao"].ToString();
                    }

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }

        }
        public void ObjVazio()
        {
            codigo = null;
            nome = null;


            barControle = null;
            barData = null;
            barHora = null;
            barCodigoBarra = null;
            barValor = null;
            barPeso = null;
            barBipado = null;
        }
        public void InsertProducaoCodBarBalcao()
        {

            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "insert into Producao_Cod_Barra ( controle, data, hora, codigo, descricao, codigo_Barra, bipado, balcao ) values (@controle, @data, @hora, @codigo, @descricao, @codigo_Barra, false, true);";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);

            comando.Parameters.AddWithValue("controle", barControle);
            comando.Parameters.AddWithValue("data", barData);
            comando.Parameters.AddWithValue("hora", barHora);
            comando.Parameters.AddWithValue("codigo", codigo);
            comando.Parameters.AddWithValue("descricao", nome);
            comando.Parameters.AddWithValue("codigo_Barra", barCodigoBarra);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void AlterarBipadoTrue(string refCodigoBar)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);

            try
            {
                conexao.Open();
                string comandoString = "update Producao_Cod_Barra set  bipado = true where codigo_Barra ='" + refCodigoBar + "';";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);
                comando.ExecuteNonQuery();

            }
            catch (Exception a)
            {
                //MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
        public void BuscarDadosProdutosProdCod(string refCodigoBar)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                OleDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "select * from Producao_Cod_Barra where codigo_Barra = '" + refCodigoBar + "';";
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["codigo_Barra"] != null)
                    {
                        codBarra = reader["codigo_Barra"].ToString();
                    }

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conexao.Close();
            }

        }
        public void CarregarDataGridAccess(DataGridView dataGridView)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            try
            {

                string comandoString = "select * from Producao_Cod_Barra where codigo = " + codigo + " order by controle asc ";
                OleDbCommand comando = new OleDbCommand(comandoString, conexao);

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(comando);

                DataTable dtLista = new DataTable();

                dataAdapter.Fill(dtLista);

                dataGridView.DataSource = dtLista;
            }
            catch (Exception a)
            {
                // MessageBox.Show("Erro: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }




        }
        public void DeleteCodigoBarra(string refCodigo_Barra)
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            string comandoString = "DELETE FROM Producao_Cod_Barra where codigo_Barra = '" + refCodigo_Barra + "0';";
            OleDbCommand comando = new OleDbCommand(comandoString, conexao);


            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}
