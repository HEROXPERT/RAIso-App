using RAIso_BARUUU.Dataset;
using RAIso_BARUUU.Model;
using RAIso_BARUUU.Report;
using RAIso_BARUUU.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Admin
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 data = getData(TransactionHeaderRepository.getTransactionHeader());
            report.SetDataSource(data);
        }

        private DataSet1 getData(List<TransactionHeader> transactions)
        {
            DataSet1 data = new DataSet1();
            var headertable = data.TransactionHeader;
            var detailtable = data.TransactionDetail;

            foreach (TransactionHeader t in transactions)
            {
                var hrow = headertable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                headertable.Rows.Add(hrow);

                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailtable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["StationeryID"] = d.StationeryID;
                    drow["Quantity"] = d.Quantity;
                    detailtable.Rows.Add(drow);
                }
            }
            return data;

        }
    }
}