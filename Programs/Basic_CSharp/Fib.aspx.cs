using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fib : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int m = 0;
        HttpContext.Current.Response.Write("Fibonacci Series : <br>");
        for (int k = 4; k > 0; k--)
        {
           
            for (int j = 0; j < k; j++)
            {
               
                int[] fib = new int[20];
                fib[0] = 0;
                fib[1] = 1;

                for (int i = 0; i < 10; i++)
                {
                    fib[i + 2] = fib[i] + fib[i + 1];
                } 
                HttpContext.Current.Response.Write(" " + fib[m]);
                 m++; 
            } HttpContext.Current.Response.Write("  <br> \n");
        }
        
    }
}
