﻿using StockManagementSystem.DLL;
using StockManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace StockManagementSystem
{
    public partial class SearchItem : Form
    {
        public SearchItem()
        {
            InitializeComponent();
            showDataGridView.ReadOnly = true;
            this.showDataGridView.Columns[1].Visible = false;
            CompanyFill();
        }
        SearchItemManage searchItemManage = new SearchItemManage();
        public void CompanyFill()
        {
            DataTable dt = searchItemManage.CompanyValue();
            List<Company> companyList = new List<Company>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    companyList.Add(new Company()
                    {
                        Id = Convert.ToInt32(dt.Rows[i]["Id"].ToString()),
                        CompanyName = dt.Rows[i]["CompanyName"].ToString(),
                    });
                }
                companyComboBox.DataSource = companyList;
                CategoryFill(Convert.ToInt32(companyComboBox.SelectedValue));
            }
        }
        List<TakeSearchItem> takeSearchItemList;
        public void CategoryFill(int companyIdd)
        {
            takeSearchItemList = new List<TakeSearchItem>();
            DataTable dt = searchItemManage.CategoryValue(companyIdd);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    takeSearchItemList.Add(new TakeSearchItem()
                    {
                        CategoryId = Convert.ToInt32(dt.Rows[i]["Id"].ToString()),
                        CategoryName = dt.Rows[i]["CategoryName"].ToString(),
                        CompanyName = dt.Rows[i]["CompanyName"].ToString(),
                        ReorderLevel =Convert.ToInt32(dt.Rows[i]["ReorderLevel"].ToString()),
                        Quantity =Convert.ToInt32(dt.Rows[i]["Quantity"].ToString()),
                        ItemName = dt.Rows[i]["ItemName"].ToString(),
                        Sno = ++i,
                    });
                }
                categoryComboBox.DataSource = takeSearchItemList;
            }
        }
        int companyIddd = 0;
        int categoryIddd = 0;
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                companyIddd = Convert.ToInt32(companyComboBox.SelectedValue);
                categoryIddd = Convert.ToInt32(categoryComboBox.SelectedValue);

                var item = takeSearchItemList.Where(x => x.CategoryId == categoryIddd).ToList();
                showDataGridView.DataSource = item;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Selct combo box");
            }
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryFill(Convert.ToInt32(companyComboBox.SelectedValue));
        }
        
        
    }
}
