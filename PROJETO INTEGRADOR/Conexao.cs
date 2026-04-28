using Microsoft.Data.Sqlite;
using System;

namespace PROJETO_INTEGRADOR
{
    public static class Conexao
    {
        // String de conexão (corrigida)
        private static readonly string strConn =
            "Data Source=protegelar.db;" +
            "Cache=Shared;" +
            "Pooling=True;";

        public static SqliteConnection GetConexao()
        {
            return new SqliteConnection(strConn);
        }

        public static void InicializarBanco()
        {
            using (var conn = GetConexao())
            {
                conn.Open();

                // ⏱️ Define tempo de espera quando banco estiver ocupado
                using (var timeout = conn.CreateCommand())
                {
                    timeout.CommandText = "PRAGMA busy_timeout = 5000;";
                    timeout.ExecuteNonQuery();
                }

                // ⚡ Melhora concorrência (leitura + escrita)
                using (var pragma = conn.CreateCommand())
                {
                    pragma.CommandText = "PRAGMA journal_mode=WAL;";
                    pragma.ExecuteNonQuery();
                }

                // 📦 Criação das tabelas
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Usuarios (
                        id_usuario INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome_completo TEXT NOT NULL,
                        email TEXT UNIQUE NOT NULL,
                        senha TEXT NOT NULL,
                        endereco TEXT,
                        telefone TEXT
                    );

                    CREATE TABLE IF NOT EXISTS Servicos (
                        id_servico INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome_servico TEXT NOT NULL,
                        preco_m2 REAL NOT NULL,
                        categoria TEXT
                    );

                    CREATE TABLE IF NOT EXISTS Orcamentos (
                        id_orcamento INTEGER PRIMARY KEY AUTOINCREMENT,
                        id_usuario INTEGER,
                        valor_total REAL NOT NULL,
                        data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario)
                    );

                    CREATE TABLE IF NOT EXISTS itens_orcamento (
                        id_item INTEGER PRIMARY KEY AUTOINCREMENT,
                        id_orcamento INTEGER,
                        id_servico INTEGER,
                        largura REAL,
                        altura REAL,
                        subtotal_item REAL,
                        FOREIGN KEY (id_orcamento) REFERENCES Orcamentos(id_orcamento),
                        FOREIGN KEY (id_servico) REFERENCES Servicos(id_servico)
                    );
                    ";

                    cmd.ExecuteNonQuery();
                }

                // 🔍 Verifica se já existem serviços cadastrados
                using (var check = conn.CreateCommand())
                {
                    check.CommandText = "SELECT COUNT(*) FROM Servicos;";
                    long count = (long)check.ExecuteScalar();

                    if (count == 0)
                    {
                        using (var insert = conn.CreateCommand())
                        {
                            insert.CommandText = @"
                            INSERT INTO Servicos (nome_servico, preco_m2, categoria) VALUES
                            ('Rede de Proteção para Janelas', 35.00, 'Redes de Proteção'),
                            ('Rede de Proteção para Sacadas', 48.00, 'Redes de Proteção'),
                            ('Rede de Proteção para Escadas', 42.00, 'Redes de Proteção'),
                            ('Tela Mosquiteira Fixa', 85.00, 'Telas Mosquiteiras'),
                            ('Pintura Interna', 165.00, 'Pintura Residencial'),
                            ('Drywall Parede', 100.00, 'Gesso e Drywall');
                            ";

                            insert.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}