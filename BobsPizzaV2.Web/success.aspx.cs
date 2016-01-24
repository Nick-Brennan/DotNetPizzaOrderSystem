using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BobsPizzaV2.Web
{
    public partial class success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void returnButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx");
        }
    }
}