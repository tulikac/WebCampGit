using SharedComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAWSHOL
{
    public partial class YSOD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Utilities.GetData();
            message.Text = "Page Loaded Successfully";
        }
    }
}