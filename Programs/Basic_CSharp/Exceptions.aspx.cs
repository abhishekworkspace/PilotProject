using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exceptions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            int[] list = { 1, 3, 6 };
            HttpContext.Current.Response.Write("Index : " + list[10]);
        }
        catch (Exception a)
        {
            HttpContext.Current.Response.Write(a.Message);
        }
        finally
        {
            HttpContext.Current.Response.Write("<br><br> The exceptions are handled here <br>");
        }
  
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        int age = Convert.ToInt32(txtaddData.Text.Trim());
        try
        {
            if (age < 18)
            {
                throw new ArithmeticException("<br>You must be 18 years or older !"); //FileNotFoundException, IndexOutOfRangeException, TimeOutException
            }
            else
            {
                HttpContext.Current.Response.Write("<br>Acess granted ! You are eligible now. ");
            }
        }
        catch (Exception x)
        {
            HttpContext.Current.Response.Write(x.Message);
        }
    }

}