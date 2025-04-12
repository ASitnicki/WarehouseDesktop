using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseDesktop.Data;

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
            loadItems();
        }
        private void loadItems()
        {
            Repository repository = Repository.getInstance();
            List<Item> items = repository.GetItems();
            int index = 1;
            stockPanel.RowCount = items.Count + 1;
            stockPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            clearTable();
            foreach (Item item in items)
            {
                Label labelId = new Label();
                labelId.Text = item.id.ToString();
                labelId.AutoSize = true;
                labelId.Margin = new Padding(5);
                labelId.Dock = DockStyle.Fill;
                labelId.TextAlign = ContentAlignment.MiddleCenter;
                stockPanel.Controls.Add(labelId, 0, index);

                Label labelName = new Label();
                labelName.Text = item.name;
                labelName.AutoSize = true;
                labelName.Dock = DockStyle.Fill;
                labelName.TextAlign = ContentAlignment.MiddleCenter;
                stockPanel.Controls.Add(labelName, 1, index);

                Label labelPrice = new Label();
                labelPrice.Text = item.price.ToString();
                labelPrice.AutoSize = true;
                labelPrice.Dock = DockStyle.Fill;
                labelPrice.TextAlign = ContentAlignment.MiddleCenter;
                stockPanel.Controls.Add(labelPrice, 2, index);

                Label labelQuantity = new Label();
                labelQuantity.Text = item.quantity.ToString();
                labelQuantity.AutoSize = true;
                labelQuantity.Dock = DockStyle.Fill;
                labelQuantity.TextAlign = ContentAlignment.MiddleCenter;
                stockPanel.Controls.Add(labelQuantity, 3, index);

                Label labelDate = new Label();
                labelDate.Text = item.expirationDate.ToString();
                labelDate.AutoSize = true;
                labelDate.Dock = DockStyle.Fill;
                labelDate.TextAlign = ContentAlignment.MiddleCenter;
                stockPanel.Controls.Add(labelDate, 4, index);

                Label labelCode = new Label();
                labelCode.Text = item.barcode.ToString();
                labelCode.AutoSize = true;
                labelCode.Dock = DockStyle.Fill;
                labelCode.TextAlign = ContentAlignment.MiddleCenter;
                stockPanel.Controls.Add(labelCode, 5, index);

                index++;
            }
        }
        private void clearTable()
        {
            for (int i = stockPanel.Controls.Count - 1; i >= 0; i--)
            {
                if (stockPanel.GetRow(stockPanel.Controls[i]) > 0)
                {
                    stockPanel.Controls.RemoveAt(i);
                }
            }
        }
    }
}
