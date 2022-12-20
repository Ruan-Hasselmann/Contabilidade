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
            Uid = "sacnet";
            Password = "ik9rru2j*@";
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

        public bool InserirFornecedor(Fornecedor Fornecedor)
        {
            try
            {
                string query = string.Format("INSERT INTO Fornecedor (nomeFornecedor) values('{0}')", Fornecedor.nomeFornecedor);
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

        public bool InserirCliente(Cliente Cliente)
        {
            try
            {
                string query = string.Format("INSERT INTO Cliente (nomeCliente) values('{0}')", Cliente.nomeCliente);
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

        public bool AlterarFornecedor(Fornecedor obj)
        {
            try
            {
                string query = string.Format("update Fornecedor set nomeFornecedor='{0}' WHERE idFornecedor = {1}", obj.nomeFornecedor, obj.Codigo);
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
        
        public bool AlterarCliente(Cliente obj)
        {
            try
            {
                string query = string.Format("update Cliente set nomeCLiente='{0}' WHERE idCliente = {1}", obj.nomeCliente, obj.Codigo);
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

        public bool ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                string query = string.Format("delete from Fornecedor where idFornecedor  = {0}", obj.Codigo);
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
        
        public bool ExcluirCliente(Cliente obj)
        {
            try
            {
                string query = string.Format("delete from Cliente where idCliente  = {0}", obj.Codigo);
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

        public List<Fornecedor> ListarFornecedor()
        {
            List<Fornecedor> listaRegistros = new List<Fornecedor>();

            try
            {
                AbrirConexao();
                string query = @"SELECT * FROM Fornecedor";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Fornecedor obj = new Fornecedor();
                    obj.Codigo = Convert.ToInt32(reader["idFornecedor"]);
                    obj.nomeFornecedor = reader["nomeFornecedor"].ToString();
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
        
        public List<Cliente> ListarCliente()
        {
            List<Cliente> listaRegistros = new List<Cliente>();

            try
            {
                AbrirConexao();
                string query = @"SELECT * FROM Cliente";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente obj = new Cliente();
                    obj.Codigo = Convert.ToInt32(reader["idCliente"]);
                    obj.nomeCliente = reader["nomeCliente"].ToString();
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

        public List<MovimentacaoProduto> ListarMovimentacoes()
        {
            List<MovimentacaoProduto> listaRegistros = new List<MovimentacaoProduto>();

            try
            {
                AbrirConexao();
                string query = @"SELECT idMov ,operacao ,valor, qtd, tipoPagamento, fk_idProduto, fk_idCliente, fk_idFornecedor,parcelas,entrada FROM MOVIMENTACOES";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MovimentacaoProduto obj = new MovimentacaoProduto();
                    obj.Codigo = Convert.ToInt32(reader["idProduto"]);
                    obj.Operacao = (Operacao)Convert.ToInt32(reader["operacao"]);
                    obj.valor = Convert.ToDouble(reader["valor"]);
                    obj.quantidade = Convert.ToInt32(reader["qtd"]);
                    obj.TipoPagamento = (TipoPagamento)Convert.ToInt32(reader["tipoPagamento"]);
                    obj.CodigoProduto = Convert.ToInt32(reader["idProduto"]);
                    obj.CodigoCliente  = (reader["fk_idCliente"] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader["fk_idCliente"]);
                    obj.CodigoFornecedor = (reader["fk_idFornecedor"] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader["fk_idFornecedor"]);
                    obj.Codigo = Convert.ToInt32(reader["idProduto"]);
                    obj.Operacao = (Operacao)Convert.ToInt32(reader["operacao"]);
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

        public List<MovimentacaoProduto> CarregarProdutosMovimentacoes(List<MovimentacaoProduto> Lista)
        {
            List<Produto> ListaProdutos = this.ListarProdutos();

            foreach (MovimentacaoProduto obj in Lista)
            {
                if (ListaProdutos.Exists(x => x.Codigo == obj.CodigoProduto.Value))
                    obj.Produto = ListaProdutos.First(x => x.Codigo == obj.CodigoProduto.Value);
            }

            return Lista;
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

        public bool InserirMovimentacaoCompra(MovimentacaoProduto Movimentacao)
        {
            try
            {
                string query = string.Format("INSERT INTO MOVIMENTACOES (operacao, valor, qtd, tipoPagamento, fk_idProduto, fk_idFornecedor, parcelas, entrada) " +
                    "values({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", (int)Movimentacao.Operacao, Movimentacao.valor, Movimentacao.quantidade, (int)Movimentacao.TipoPagamento, Movimentacao.CodigoProduto, Movimentacao.CodigoFornecedor, Movimentacao.Parcelas, Movimentacao.entrada) ;
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

        public bool InserirMovimentacaoVenda(MovimentacaoProduto Movimentacao)
        {
            try
            {
                string query = string.Format("INSERT INTO MOVIMENTACOES (operacao, valor, qtd, tipoPagamento, fk_idProduto, fk_idCliente, parcelas, entrada) " +
                    "values({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", (int)Movimentacao.Operacao, Movimentacao.valor, Movimentacao.quantidade, (int)Movimentacao.TipoPagamento, Movimentacao.CodigoProduto, Movimentacao.CodigoCliente, Movimentacao.Parcelas, Movimentacao.entrada);
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

        public bool AtualizarEstoque(MovimentacaoProduto Movimentacao)
        {
            try
            {
                string query = string.Format("UPDATE PRODUTOS SET qtdEstoque = {0} WHERE idProduto = {1} ", Movimentacao.Operacao.Equals(Operacao.Compra) ? (Movimentacao.quantidade + Movimentacao.Produto.Estoque) : (Movimentacao.Produto.Estoque - Movimentacao.quantidade) , Movimentacao.CodigoProduto);
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

        public List<VwGeral> ListarVwGeral()
        {
            List<VwGeral> listaRegistros = new List<VwGeral>();

            try
            {
                AbrirConexao();
                string query = @"SELECT 
                                    idMov,
                                    operacao,
                                    valor,
                                    qtd,
                                    tipoPagamento,
                                    fk_idProduto,
                                    fk_idCliente,
                                    fk_idFornecedor,
                                    idProduto,
                                    descricao_produto,
                                    idCliente,
                                    nome_cliente,
                                    idFornecedor,
                                    nome_fornecedor,
                                    parcelas,
                                    entrada,
                                    margem
                                                FROM Geral";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    VwGeral obj = new VwGeral();
                    obj.IdMovimentacao = Convert.ToInt32(reader["idMov"]);
                    obj.operacao = (Operacao)Convert.ToInt32(reader["operacao"]);
                    obj.valor = Convert.ToDecimal(reader["valor"]);
                    obj.quantidade = Convert.ToInt32(reader["qtd"]);
                    obj.TipoPagamento = (TipoPagamento)Convert.ToInt32(reader["tipoPagamento"]);
                    obj.IdProduto = Convert.ToInt32(reader["fk_idProduto"]);
                    obj.DescricaoProduto = reader["descricao_produto"].ToString();
                    obj.IdCLiente = (reader["fk_idCliente"] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader["fk_idCliente"]);
                    obj.NomeCLiente = reader["nome_cliente"].ToString();
                    obj.IdFonecedor = (reader["fk_idFornecedor"] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader["fk_idFornecedor"]);
                    obj.NomeFornecedor = reader["nome_fornecedor"].ToString();
                    obj.Parcelas = Convert.ToInt32(reader["parcelas"]);
                    obj.Entrada = Convert.ToInt32(reader["entrada"]);
                    obj.Margem = Convert.ToDecimal(reader["margem"]);

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
