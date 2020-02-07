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
        string Host { get; set; }
        string Name { get; set; }
        MD5 Password { get; set; } 
        int Port { get; set; }
    }
}
