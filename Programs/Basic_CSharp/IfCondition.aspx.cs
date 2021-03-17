using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IfCondition : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = 10, j = 20;
        if (i > j)
            HttpContext.Current.Response.Write("Difference between i an d j : " + (i - j));
        else
            HttpContext.Current.Response.Write("Difference between i an d j : " + (j - i));
    }
}