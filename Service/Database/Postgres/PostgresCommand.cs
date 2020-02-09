using PgCommand.Dominio;
using PgCommand.Enum;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgCommand.Service.Database.Postgres
{
    public static class PostgresCommand
    {
        public static EnumVersaoPostgres Versao 
        { 
            get
            {
                var version = ConfigurationManager.AppSettings.Get("VersaoPostgres");
                return (EnumVersaoPostgres)int.Parse(version);
            }
            set
            {
                ConfigurationManager.AppSettings.Set("VersaoPostgres", value.ToString());
            }
        }

        public static Dictionary<string, string> Pg_isReady(ConnectString connect)
        {
            var comando = new Dictionary<string, string>();
            switch (Versao)
            {
                case EnumVersaoPostgres.Versao_11:
                    comando.Add("Pg_isReady.exe", string.Empty);
                    comando.Add("--host", connect.Host);
                    comando.Add("--port", connect.Port.ToString());
                    comando.Add("--username", connect.User);
                    comando.Add("--dbname", connect.Host);
                    break;

                default:
                    throw new NotImplementedException($"Pg_isReady: Versão ({Versao}) não implementada");
            }
            return comando;
        }
    }
}
