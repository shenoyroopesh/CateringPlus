using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CateringApp.Reports;

namespace CateringApp.UserControls
{
    public partial class DailyItemsReportUI : UserControl
    {
        public DailyItemsReportUI()
        {
            InitializeComponent();
            this.Resize += new EventHandler(DailyItemsReportUI_Resize);
        }

        void DailyItemsReportUI_Resize(object sender, EventArgs e)
        {
            mainPanel.Width = this.Width * 8 / 10;
            mainPanel.Height = this.Height * 9 / 10;
            dtDate.Left = mainPanel.Width * 4 / 10;
            btnGenerate.Left = mainPanel.Width * 6 / 10;
            reportViewer1.Width = mainPanel.Width;
            reportViewer1.Height = mainPanel.Height * 8 / 10;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DailyItemsReport", LoadDailyItemsReport()));
            reportViewer1.RefreshReport();
        }

        private List<DailyItemsReport> LoadDailyItemsReport()
        {
            List<DailyItemsReport> items = new List<DailyItemsReport>();
            using (LocalDBEntities ctx = new LocalDBEntities())
            {
                var fromDate = dtDate.Value.Date;
                var toDate = dtDate.Value.Date.AddDays(1);

                var dbItems = from i in ctx.OrderItems
                              where i.OrderItemGroup.Order.Date >= fromDate &&
                                    i.OrderItemGroup.Order.Date < toDate
                              group i by new { i.Name, i.OrderItemGroup.Order.Date} into g
                              select new
                              {
                                  Name = g.Key.Name,
                                  Date = g.Key.Date,
                                  Qty = g.Sum(i=> i.OrderItemGroup.Quantity)
                              };

                foreach (var i in dbItems)
                {
                    DailyItemsReport item = new DailyItemsReport();
                    item.Name = i.Name;
                    item.Date = i.Date;
                    item.Quantity = i.Qty;
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
