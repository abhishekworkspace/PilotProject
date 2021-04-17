using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Swap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int a=3, b=5, c=4;
        a = a + b + c - (a + c);
        b = a + b + c - (a + b);
        c = a + b + c - (b + c);
        //  a = b;
        // b = c;
     
        HttpContext.Current.Response.Write(" A : " + a + " B : " + b + " C : " + c);
    }
}