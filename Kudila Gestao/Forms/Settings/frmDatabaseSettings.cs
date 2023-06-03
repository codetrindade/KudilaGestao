using Kudila_Gestao.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kudila_Gestao.Forms.Settings
{
    public partial class frmDatabaseSettings : Form
    {
        public frmDatabaseSettings()
        {
            InitializeComponent();
        }

        private void frmDatabaseSettings_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DbSettings dbSettings = new DbSettings();
           if( dbSettings.Connect(txtUser.Text, txtPassword.Text, txtDatabase.Text, toggleSwitch1.IsOn))
            {
                MessageBox.Show("Sucesso");
            }
            else
            {

                MessageBox.Show("Erro");
            }
        }
    }
}
