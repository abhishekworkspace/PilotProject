using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 10; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            { 
                HttpContext.Current.Response.Write(" * \n");
            } HttpContext.Current.Response.Write("  <br> \n");
        }
    }
}