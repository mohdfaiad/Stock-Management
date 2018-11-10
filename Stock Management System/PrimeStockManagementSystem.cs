using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class PrimeStockManagementSystem : Form
    {
        public PrimeStockManagementSystem()
        {
            InitializeComponent();
        }

        private void CategorySetupButton_Click(object sender, EventArgs e)
        {
            CategorySetup categorySetup = new CategorySetup();
            categorySetup.ShowDialog();
        }

        private void CompanySetupButton_Click(object sender, EventArgs e)
        {
            CompanySetup companySetup = new CompanySetup();
            companySetup.ShowDialog();
        }

        private void ItemSetupButton_Click(object sender, EventArgs e)
        {
            ItemSetup itemSetup = new ItemSetup();
            itemSetup.ShowDialog();
        }

        private void StockInButton_Click(object sender, EventArgs e)
        {
            StockIn stockIn = new StockIn();
            stockIn.ShowDialog();
        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            StockOut stockOut = new StockOut();
            stockOut.ShowDialog();
        }

        private void SearchAndViewItemsSummaryButton_Click(object sender, EventArgs e)
        {
            SearchAndViewItemsSummary searchAndView = new SearchAndViewItemsSummary();
            searchAndView.ShowDialog();
        }

        private void ViewSalesBetweenTwoDatesButton_Click(object sender, EventArgs e)
        {
            ViewSalesBetweenTwoDates viewSales = new ViewSalesBetweenTwoDates();
            viewSales.ShowDialog();
        }
    }
}
