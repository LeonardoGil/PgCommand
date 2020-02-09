using PgCommand.Dominio;
using PgCommand.Extensions;
using PgCommand.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgCommand.Service.Database.Postgres
{
    public class PostgresService : IDatabase
    {
        private readonly IComando _comando;

        public PostgresService(IComando comando)
        {
            _comando = comando;
        }

        public bool ValidarConexao(ConnectString obj)
        {
            var comando = PostgresCommand.Pg_isReady(obj).MontarComando(@"C:\Program Files\PostgreSQL\11\bin\");
            var retorno = _comando.Execute(comando);
            return true;
        }

        
    }
}
