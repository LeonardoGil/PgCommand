using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgCommand.Interface
{
    public interface IComando
    {
        string Execute(string comandos, params string[] parametros);
    }
}
