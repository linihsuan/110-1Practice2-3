using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_3
{
    public partial class Reflect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //要判斷的數值
            int M = 663166;

            //辨識第幾位數(餘數)
            int den = 0;

            //計算後的餘數
            int sum = 0;

            while (M != 0)
            {
                sum = M % 10;
                den = den * 10 + sum;
                M = M / 10;
            }
                
            if (M == den)
                Response.Write("True");

            else
                Response.Write("False");
        }
    }
}