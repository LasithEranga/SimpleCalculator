using Xamarin.Forms;
using org.mariuszgromada.math.mxparser;
using System.Text.RegularExpressions;

namespace Simple_Calculator
{
    public partial class MainPage : ContentPage
    {
        
        Regex rgx = new Regex("^[0]");
        public MainPage()
        {
            InitializeComponent();
        }
        

        int sum = 0;
        void click1(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text+"1";
            
        }

        void click2(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "2";

        }

        void click3(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "3";

        }

        void click4(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "4";

        }

        void click5(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "5";

        }

        void click6(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "6";

        }

        void click7(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "7";

        }

        void click8(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "8";

        }

        void click9(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "9";

        }

        void click0(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "0";

        }

        void plus(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "+";

        }

        void minus(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "-";

        }

        void divide(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "/";

        }

        void multiply(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + "*";

        }

        void docalc(object sender, System.EventArgs e)
        {
            if (txt1.Text.Contains("0/0"))
            {
                txt1.Text = "Even we don't know";
            }
            else if (txt1.Text.Contains("/0"))
            {
                txt1.Text = "It's Infinity";
            }
            else
            {
                Expression ex = new Expression(txt1.Text);
                double v = ex.calculate();
                
                if(v is double.NaN)
                {
                   txt1.Text = "Syntax Error";
                }
                else
                {
                    txt1.Text = v.ToString();
                }
               
            }
        }

        void dot(object sender, System.EventArgs e)
        {
            txt1.Text = txt1.Text + ".";

        }



        void clear(object sender, System.EventArgs e)
        {
            txt1.Text = "";

        }
    }

   
}
