using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ext : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int[] n = new int[110];
        for (int i = 0; i < 110; i++)
        {
            n[i] = i + 10;
        }
            foreach (int j in n)
            {
                int i = 110 - j;
                HttpContext.Current.Response.Write(" <br> No[" + i + "] : " + j);
            }

    }
}