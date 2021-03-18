using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pattern : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
        int x=15;

     int i,j;
    for(i=-x;i<x;i++)
    {
        for(j=-x;j<x;j++)
        {
            if(i*i+j*j<x*x)
                HttpContext.Current.Response.Write(" * ");
            else
                HttpContext.Current.Response.Write(" ");
        }
        HttpContext.Current.Response.Write("<br>");
    }

    }
}