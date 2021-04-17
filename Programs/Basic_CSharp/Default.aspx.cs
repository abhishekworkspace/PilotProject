using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpContext.Current.Response.Write("All odd numbers between 1 to 100<br>");
        for (int i = 0; i < 100; i++)
        {
            if(i%2!=0)
            HttpContext.Current.Response.Write(i.ToString() + ", ");

        }
    }
}