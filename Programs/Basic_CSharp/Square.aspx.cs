using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Square : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int k = 1;
        for (int i = 0; i < 7; i++)
        {
            
            for ( int j = 1; j < i; j++)
            {
               
                HttpContext.Current.Response.Write(k * k + " ");
                k++;
            }
            HttpContext.Current.Response.Write("<br>");
        }
    }
}