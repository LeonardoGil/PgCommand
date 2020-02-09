using PgCommand.Interface;
using PgCommand.Service.Comando;
using PgCommand.Service.Database.Postgres;
using SimpleInjector;

namespace PgCommand.Infra
{
    public static class DependencyInjection
    {
        public static Container Config()
        {
            var container = new Container();

            //Arquivo
            container.RegisterSingleton<IComando, ComandoService>();
            container.RegisterSingleton<IDatabase, PostgresService>();

            container.RegisterSingleton<FrmPrincipal>();

            container.Verify();
            return container;
        }
    }
}
