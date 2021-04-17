using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Switch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      // for (int day = 1; day < 8; day++ ){  
      //  HttpContext.Current.Response.Write(" Enter day number of week you wish to see");
      // int day = Console.Read();
           
           // }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        switch (Convert.ToInt32(txtmoreData.Text.Trim()))

        {
            case 1: HttpContext.Current.Response.Write("Ohh Monday! <br><br> "); break;

            case 2: HttpContext.Current.Response.Write("Tuesday Only! <br><br> "); break;

            case 3: HttpContext.Current.Response.Write("Wednesday awaits ! <br><br> "); break;

            case 4: HttpContext.Current.Response.Write("Its Thrusday ! <br><br> "); break;

            case 5: HttpContext.Current.Response.Write("Friday Yay ! <br><br> "); break;

            case 6: HttpContext.Current.Response.Write("Wow Saturday ! <br><br> "); break;

            case 7: HttpContext.Current.Response.Write("Sunday Funday ! <br><br> "); break;

            default: HttpContext.Current.Response.Write("What a day ! <br><br> "); break;

        }
    }
}