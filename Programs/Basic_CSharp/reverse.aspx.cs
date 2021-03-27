using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reverse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int rem;
        int rev = 0;

        for (int i = 1256546; i >  0;   i = i / 10)
        {
           
           
            rem = i % 10;
            int reversal = rev *10+ rem;
            HttpContext.Current.Response.Write(reversal);
         
            }
       
       
    
    }
}