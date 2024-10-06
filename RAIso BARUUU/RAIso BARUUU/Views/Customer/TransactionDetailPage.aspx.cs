using RAIso_BARUUU.Model;
using RAIso_BARUUU.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Customer
{
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            List<TransactionDetail> td = TransactionDetailRepository.getTransactionDetail(id);
            DetailGV.DataSource = td;
            DetailGV.DataBind();
        }
    }
}