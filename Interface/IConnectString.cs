using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PgCommand.Interface
{
    interface IConnectString
    {
        string User { get; set; }
        string Host { get; set; }
        string Name { get; set; }
        string Password { get; set; } 
        int Port { get; set; }

        string BuildString();
    }
}
