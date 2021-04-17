using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TopDnBin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int  rem = 0;

        for (int i = 0; i < 5; i++)
        {
        
            for (int j = 5; j > i; j--) 
            {
                if (i / 2 == 0)
                        rem = j % 2;
                    else
                        rem = (j+1) % 2;
                    HttpContext.Current.Response.Write(rem);
              
            
            } 
            HttpContext.Current.Response.Write("<br>");
        }
    }
}/*
        int count=0;
        int[] m = new int[40]; 
        for (int i = 5; i > 0; i--)
        {
        
            for (int j = 0; j < i; j++) 
            {
             
                count++;
                if (count % 2 == 0)
                    m[count] = 0;
                else
                    m[count] = 1;
                HttpContext.Current.Response.Write(m[count]);
            } 
            HttpContext.Current.Response.Write("<br>");     count++;
                if (count % 2 == 0)
                    m = 0;
                else
                    m = 1;
21/2 = 1
10/2 = 0
5/ 2 = 1
2/2  = 0
1/2 = 1*/