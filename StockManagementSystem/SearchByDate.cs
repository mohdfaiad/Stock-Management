using StockManagementSystem.DLL;
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
    public partial class SearchByDate : Form
    {
        public SearchByDate()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!(fromDateTimePicker.Value.Date.CompareTo(toDateTimePiker.Value.Date)<0))
            {
                MessageBox.Show("Must be From timepicker less than To timepicker");
            }
            else
            {
                ShowAllData(fromDateTimePicker.Value,toDateTimePiker.Value);
            }
        }
        SearchItemManage searchItemManage = new SearchItemManage();
        public void ShowAllData(DateTime fromDate,DateTime toDate)
        {
            DataTable dt = searchItemManage.SellQuantity(fromDate, toDate);
            List<SearchItemByDate> itemList = new List<SearchItemByDate>();
            if (dt.Rows.Count > 0)
            {
                int sNo=0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    itemList.Add(new SearchItemByDate()
                    {
                        Sl=++sNo,
                        ItemName = dt.Rows[i]["ItemName"].ToString(),
                        SellQuantity = Convert.ToInt32(dt.Rows[i]["QuantityTotal"].ToString()),
                    });
                }
                showGridView.DataSource = itemList;
            }
        }
       
    }
}
