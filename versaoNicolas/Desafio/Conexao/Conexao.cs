using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidades;
using System.Text;

namespace BaseDados
{
    public class Conexao
    {
        private MySqlConnection Connection;
        private string Server;
        private string Database;
        private string Uid;
        private string Password;
        private string Port;
        public Conexao()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            Server = "127.0.0.1";
            Database = "db_contabilidade;";
            Uid = "root";
            Password = "laboratorio";
            Port = "3306";
            string connectionstring = "SERVER=" + Server + ";" + "PORT=" + Port + ";" + "DATABASE=" +
            Database + ";" + "UID=" + Uid + ";" + "PASSWORD=" + Password + ";";

            this.Connection = new MySqlConnection(connectionstring);
        }

        public bool AbrirConexao()
        {
            try
            {
                Connection.Open();
                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExecutarQuery(string query)
        {
            int r = 0;
            try
            {
                AbrirConexao();
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                r = cmd.ExecuteNonQuery();
            }

            finally
            {
                FecharConexao();
            }

            return r > 0;
        }

        public bool FecharConexao()
        {
            try
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();

                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public bool InserirProduto(Produto Produto)
        {
            try
            {
                string query = string.Format("INSERT INTO Produtos (descricao, qtdEstoque, margem) values('{0}', {1}, {2})", Produto.Descricao, Produto.Estoque, Produto.Margem);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public bool AlterarProduto(Produto obj)
        {
            try
            {
                string query = string.Format("update produtos set descricao='{0}', qtdEstoque={1}, margem = {2} WHERE idProduto = {3}", obj.Descricao, obj.Estoque, obj.Margem, obj.Codigo);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public bool ExcluirProduto(Produto obj)
        {
            try
            {
                string query = string.Format("delete from produtos where idProduto  = {0}", obj.Codigo);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public List<Produto> ListarProdutos()
        {
            List<Produto> listaRegistros = new List<Produto>();

            try
            {
                AbrirConexao();
                string query = @"SELECT idProduto ,descricao ,qtdEstoque, margem FROM produtos";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Produto obj = new Produto();
                    obj.Codigo = Convert.ToInt32(reader["idProduto"]);
                    obj.Descricao = reader["descricao"].ToString();
                    obj.Estoque = Convert.ToInt32(reader["qtdEstoque"]);
                    obj.Margem = Convert.ToInt32(reader["margem"]);
                    listaRegistros.Add(obj);
                }
                reader.Close();
            }

            finally
            {
                FecharConexao();
            }

            return listaRegistros;
        }

        public bool InserirPersonagem(Personagem Personagem)
        {
            try
            {
                string query = string.Format("INSERT INTO personagens (nome, codigo_Produto, XP, pontos_livres, nivel, forca, hp, destresa, defesa) " +
                    "values('{0}', '{1}', {2}, {3}, {4}, {5}, '{6}', {7}, {8}", Personagem.Nome, Personagem.Classe.Codigo, Personagem.XP, Personagem.PontosLivres, Personagem.Nivel, Personagem.Forca, Personagem.HP, Personagem.Destresa, Personagem.Defesa);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public bool AlterarPersonagem(Personagem Personagem)
        {
            try
            {
                string query = string.Format("UPDATE Personagens SET nome = '{0}', codigo_Produto = {1}, XP = {2}, pontos_livres = {3}, nivel = {4}, forca = {5}, hp = {6}, destresa = {7}, defesa = {8} " +
                    "WHERE codigo = {8}", Personagem.Nome, Personagem.Classe.Codigo, Personagem.XP, Personagem.PontosLivres, Personagem.Nivel, Personagem.Forca, Personagem.HP, Personagem.Destresa, Personagem.Destresa);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public bool ExcluirPersonagem(Personagem Personagem)
        {
            try
            {
                string query = string.Format("DELETE FROM Personagens WHERE codigo = {0}", Personagem.Codigo);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public List<Personagem> ListarPersonagens()
        {
            List<Personagem> listaRegistros = new List<Personagem>();

            try
            {
                AbrirConexao();
                string query = @"SELECT 
                                        Codigo, 
                                        nome, 
                                        codProduto, 
                                        Produto,
                                        Produto_forca,
                                        Produto_HP,
                                        Produto_destresa,
                                        Produto_defesa,
                                        XP, 
                                        pontos_livres, 
                                        nivel, 
                                        forca, 
                                        hp, 
                                        destresa, 
                                        defesa 
                                                FROM vw_personagens";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Personagem obj = new Personagem();
                    obj.Codigo = Convert.ToInt32(reader["Codigo"]);
                    obj.Nome = reader["nome"].ToString();
                    obj.Classe.Codigo = Convert.ToInt32(reader["codProduto"]);
                    obj.Classe.Descricao = reader["Produto"].ToString();
                    obj.Classe.Forca = Convert.ToInt32(reader["Produto_forca"]);
                    obj.Classe.HP = Convert.ToInt32(reader["Produto_HP"]);
                    obj.Classe.Destresa = Convert.ToInt32(reader["Produto_destresa"]);
                    obj.Classe.Defesa = Convert.ToInt32(reader["Produto_defesa"]);
                    obj.XP = Convert.ToInt32(reader["XP"]);
                    obj.PontosLivres = Convert.ToInt32(reader["pontos_livres"]);
                    obj.Nivel = Convert.ToInt32(reader["nivel"]);
                    obj.Forca = Convert.ToInt32(reader["forca"]);
                    obj.HP = Convert.ToInt32(reader["hp"]);
                    obj.Destresa = Convert.ToInt32(reader["destresa"]);
                    obj.Defesa = Convert.ToInt32(reader["defesa"]);

                    listaRegistros.Add(obj);
                }
                reader.Close();
            }

            finally
            {
                FecharConexao();
            }
            return listaRegistros;
        }

    }
}
