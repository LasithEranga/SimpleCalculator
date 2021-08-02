using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using org.mariuszgromada.math.mxparser;

namespace Simple_Calculator
{
    public partial class MainPage : ContentPage
    {
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
            Expression ex = new Expression(txt1.Text);
            double v = ex.calculate();
            txt1.Text = v.ToString();

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
