using PgCommand.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PgCommand
{
    public partial class FrmPrincipal : Form
    {
        private readonly IDatabase _postgres;

        public FrmPrincipal(IDatabase postgres)
        {
            _postgres = postgres;
            InitializeComponent();
        }

        //Formulario
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            _postgres.ValidarConexao(new Dominio.ConnectString { Host = "127.0.0.1", Name = "postgres", Port = 5432, User = "postgres" });
        }
    }
}
