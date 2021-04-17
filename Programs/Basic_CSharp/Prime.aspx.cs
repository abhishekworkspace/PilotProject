using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Prime : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 2; i < 100; i++)
        {
            for (int j = 3; j <= i; j++)
            {
               
                    if (i % j != 0)
                        HttpContext.Current.Response.Write(" : <br>" + j);
                
            }
        }
    }
}