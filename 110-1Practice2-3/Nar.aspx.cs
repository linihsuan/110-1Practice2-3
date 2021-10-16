using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_3
{
    public partial class Nar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //原始指定數值
            int num = 153;

            //N為複製一個原始數值、den為辨識第幾位數(餘數)、smu為儲存加總結果
            int N, den, sum = 0;

            N = num;

            //重覆到算完為止(<=0)
            while (N != 0)
            {
                //算出第幾位數
                den = N % 10;

                //算出相乘幾次方並加總
                sum = sum + (den * den * den);

                //去掉一位數
                N = N / 10;
            }
            //辦別是否符合 阿斯斯壯數規則
            if (sum == num)
            {
                Response.Write("True");
            }
            else
            {
                Response.Write("False");
            }
        }
    }
}