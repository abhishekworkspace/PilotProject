using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Polynominal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpContext.Current.Response.Write("<br>Value of y = x^2 + 2x + 1 : <br><br>");
        for (int i = 0; i <= 100; i++)
        {
            HttpContext.Current.Response.Write(i * i + 2 * i + 1 + "<br>");
        }
    }
}