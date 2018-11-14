using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class Home : Form
    {
        int userIdd = 0;
        public Home()
        {
            InitializeComponent();
            
        }
        //public Home(int userId)
        //{
        //    InitializeComponent();
        //    this.userIdd = userId;
        //}

       

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            ItemSetup itemSetup = new ItemSetup(userIdd);
            itemSetup.ShowDialog();
        }

        private void StockInButton_Click(object sender, EventArgs e)
        {
            StockIn stockIn = new StockIn(userIdd);
            stockIn.ShowDialog();
        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            StockOut stockOut = new StockOut();
            stockOut.ShowDialog();
        }

        private void SearchAndViewItemsSummaryButton_Click(object sender, EventArgs e)
        {
            SearchItem searchItem = new SearchItem();
            searchItem.ShowDialog();
        }

        private void ViewSalesBetweenTwoDatesButton_Click(object sender, EventArgs e)
        {
            SearchByDate search = new SearchByDate();
            search.ShowDialog();
        }
    }
}
