using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using PgCommand.Interface;

namespace PgCommand.Service.Comando
{
    public class ComandoService : IComando
    {
        public string Execute(string comando, params string[] parametros)
        {
            var mensagemRetorno = string.Empty;
            using (var shell = PowerShell.Create(RunspaceMode.NewRunspace))
            {
                shell.AddScript(comando);
                if (parametros != null && parametros.Length > 0)
                {
                    for (int index = 0; index < parametros.Length; index++) shell.AddStatement().AddScript(parametros[index]);
                }

                Collection<PSObject> results = shell.Invoke();
                var stream = shell.Streams;

                if (stream.Error.Any())   
                    mensagemRetorno = string.Join(Environment.NewLine, shell.Streams.Error.Select(x => x.Exception.Message));
                
                mensagemRetorno = string.Join(Environment.NewLine, stream.Verbose.Select(x => x.Message));
            }

            return mensagemRetorno;
        }
    }
}
