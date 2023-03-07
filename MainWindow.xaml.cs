using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public MainWindow()
        {
            InitializeComponent();
        }

        //button assisging numbers 0
        
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text += "0";
            }
        }

        //button assisging to Decimal (.)
        private void btnDcml_Click(object sender, RoutedEventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
            
        }

        //button assisging numbers 1
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text += "1";
            }
        }

        //button assisging numbers 2
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if(txtResult.Text == "0")
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text += "2";
            }
        }
        //button assisging numbers 3
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text += "3";
            }
        }

        //button assisging numbers 4
        private void brn4_Click(object sender, RoutedEventArgs e)
        {
            if(txtResult.Text == "0")
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text += "4";
            }
        }
        //button assisging numbers 5
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text += "5";
            }
        }

        //button assisging numbers 6
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text += "6";
            }
        }

        //button assisging numbers 8
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text += "8";
            }

        }
        //button assisging numbers 9
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text += "9";
            }
        }
        //button assisging -/+
        private void btnplusminus_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.Contains("-"))
            {
                txtResult.Text = txtResult.Text.Trim('-');
            }
            else
            {
                txtResult.Text = "-" + txtResult.Text;
            }
        }

        //button assisging minus
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = decimal.Parse(txtResult.Text);
            txtResult.Clear();
            operators = "-";
        }

        //button assisging plus
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = decimal.Parse(txtResult.Text);
            txtResult.Clear();
            operators = "+";
        }
        //button assisging multiplication
        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = decimal.Parse(txtResult.Text);
            txtResult.Clear();
            operators = "*";
        }
        //button assisging divide
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = decimal.Parse(txtResult.Text);
            txtResult.Clear();
            operators = "/";
        }

        //getting result for equal = symbol
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(txtResult.Text);
                    Result = valueFirst - valueSecond;
                    txtResult.Text = Result.ToString();
                    break;

                case "+":
                    valueSecond = decimal.Parse(txtResult.Text);
                    Result = valueFirst + valueSecond;
                    txtResult.Text = Result.ToString();
                    break;

                case "*":
                    valueSecond = decimal.Parse(txtResult.Text);
                    Result = valueFirst * valueSecond;
                    txtResult.Text = Result.ToString();
                    break;

                case "/":
                    valueSecond = decimal.Parse(txtResult.Text);
                    Result = valueFirst / valueSecond;
                    txtResult.Text = Result.ToString();
                    break;
            }
            
        }

        //button assisging clear the numbers
        private void btnClrMain_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            txtResult.Text = "0";
            
        }
    }
}
