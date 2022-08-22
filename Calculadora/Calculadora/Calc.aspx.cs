using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    
    public partial class Calc : System.Web.UI.Page
    {
       
     
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void soma_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(num1.Text);
            double n2 = Convert.ToDouble(num2.Text);

            var resultados = n1 + n2;
            Result.Text = Convert.ToString(resultados);

        }

        protected void menos_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(num1.Text);
            double n2 = Convert.ToDouble(num2.Text);

            var resultados = n1 - n2;
            Result.Text = Convert.ToString(resultados);

        }

        protected void vezes_Click(object sender, EventArgs e)
        {

            double n1 = Convert.ToDouble(num1.Text);
            double n2 = Convert.ToDouble(num2.Text);

            var resultados = n1 * n2;
            Result.Text = Convert.ToString(resultados);

        }

        protected void divi_Click(object sender, EventArgs e)
        {

            double n1 = Convert.ToDouble(num1.Text);
            double n2 = Convert.ToDouble(num2.Text);

            var resultados = n1 / n2;
            Result.Text = Convert.ToString(resultados);

        }

        protected void apagar_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            Result.Text = "";

        }
    }
}