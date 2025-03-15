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
    public partial class Settings: UserControl
    {
        public Settings()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
