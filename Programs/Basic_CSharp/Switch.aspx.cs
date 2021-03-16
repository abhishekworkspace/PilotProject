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
        for (int day = 1; day < 8; day++ ){  
            switch (day)
            {
                case 1: HttpContext.Current.Response.Write("Ohh Monday! "); break;

                case 2: HttpContext.Current.Response.Write("Tuesday Only! "); break;

                case 3: HttpContext.Current.Response.Write("Wednesday awaits ! "); break;

                case 4: HttpContext.Current.Response.Write("Its Thrusday ! "); break;

                case 5: HttpContext.Current.Response.Write("Friday Yay !" ); break;

                case 6: HttpContext.Current.Response.Write("Wow Saturday !" ); break;

                case 7: HttpContext.Current.Response.Write("Sunday Funday !" ); break;

                default: HttpContext.Current.Response.Write("What a day ! "); break;

                
            }
            }
    }
}