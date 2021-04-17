using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fibonacci : System.Web.UI.Page
{
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int[] fib = new int[100];
        fib[0] = 0;
        fib[1] = 1;
        HttpContext.Current.Response.Write("Fibonacci Series : ");
        for (int i = 0; i <= 28; i++)
        {
            fib[i + 2] = fib[i] + fib[i + 1];
            string result = new String(Convert.ToChar(txtmoreData.Text.Trim()), fib[i]);
            HttpContext.Current.Response.Write(" <br> " +  result);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
   
}