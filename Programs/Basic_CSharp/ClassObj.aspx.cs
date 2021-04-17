using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClassObj : System.Web.UI.Page
{
    public class Animals 
    {
       public string breed; //Access modifiers use to scope with in the program
       public void AnimalCrossing(){
           HttpContext.Current.Response.Write("<br><br>This is my pet <br>");
       }
    }
    public class dog : Animals 
    {
        
        public void bark() { HttpContext.Current.Response.Write("<br>Bow Wow !"); 
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
      dog newdog = new dog(); // instantiate class members and methods
      dog obj; // Null defined does not instantialte members and methods
      newdog.breed = "German Shepherd";
      obj = new dog();
      HttpContext.Current.Response.Write(newdog.breed);
      newdog.AnimalCrossing();
      newdog.bark();

    
    }
}