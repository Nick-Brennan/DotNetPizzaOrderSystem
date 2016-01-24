using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BobsPizzaV2.Web
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Domain.OrderManager.GetOrders();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            var row = GridView1.Rows[index];
            var orderId = Guid.Parse(row.Cells[1].Text);
            Domain.OrderManager.MarkAsCompleted(orderId);

            GridView1.DataSource = Domain.OrderManager.GetOrders();
            GridView1.DataBind();
        }
    }
}