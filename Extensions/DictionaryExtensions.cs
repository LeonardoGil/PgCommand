using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgCommand.Extensions
{
    public static class DictionaryExtensions
    {
        public static string MontarComando(this Dictionary<string, string> keys, string caminho) => string.Concat(caminho, string.Join(" ", keys.Select(x => string.IsNullOrEmpty(x.Value) ? x.Key : string.Format("{0} '{1}'", x.Key, x.Value))));
    }
}
