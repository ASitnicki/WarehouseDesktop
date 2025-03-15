using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseDesktop.Views
{
    public partial class WarehouseApp : Form
    {
        public WarehouseApp()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(new HomeScreen());
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(new Settings());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm.Instance.Show();
            this.Close();
        }
    }
}
