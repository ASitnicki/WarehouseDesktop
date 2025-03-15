using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseDesktop.Views
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.Dock = DockStyle.Fill;
        }

        private void panel1_Pad(object sender, PaintEventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
