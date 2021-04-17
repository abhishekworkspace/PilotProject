using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TheMatrix : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int[,] matrixA = new int[3,3]{{3,5,6},{5,8,9},{7,8,4}};
        int[,] matrixB = new int[3,3]{{2,6,3},{8,5,3},{8,5,3}};
        int[,] matrixC = new int[3,3];
       HttpContext.Current.Response.Write("Matrix C : <br><br>");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrixC[i,j] = matrixB[i,j] + matrixA[i,j];
                HttpContext.Current.Response.Write("    " + matrixC[i,j] );
            } HttpContext.Current.Response.Write("<br>");

            HttpContext.Current.Response.Write("<br>");
        }
    }
}