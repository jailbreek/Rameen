using Raameenn.DataSet;
using Raameenn.Handler;
using Raameenn.Model;
using Raameenn.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raameenn.View.Transaction
{
    public partial class ReportView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 data = getDataSet(TransactionHandler.getAllTransaction());
            report.SetDataSource(data);
        }

        private DataSet1 getDataSet(List<Header> transactions)
        {
            DataSet1 data = new DataSet1();
            var headerTable = data.Header;
            var detailTable = data.Detail;

            foreach (Header t in transactions)
            {
                var hrow = headerTable.NewRow();
                hrow["Id"] = t.Id;
                hrow["CustomerId"] = t.CustomerId;
                hrow["StaffId"] = t.StaffId;
                hrow["Date"] = t.Date;
                    
                foreach (Detail td in t.Details)
                {
                    var drow = detailTable.NewRow();
                    drow["RamenId"] = td.RamenId;
                    drow["Quantity"] = td.Quantity;
                    detailTable.Rows.Add(drow);
                }
            }
            return data;
        }
    }
}