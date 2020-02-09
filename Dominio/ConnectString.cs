using PgCommand.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PgCommand.Dominio
{
    public class ConnectString : IConnectString
    {
        public string User { get; set; }
        public string Host { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }

        public string BuildString() => string.Format("Server={0};Port={1};Database={2};User Id={3};Password={4}", Host, Port, Name, User, Password);
    }
}
