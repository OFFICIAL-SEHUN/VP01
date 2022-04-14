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

namespace _037_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool opFlag;
        private bool memFlag;
        private double saved;
        private string op;
        private bool afterCalc;
        private double memory;

        public MainWindow()
        {
            InitializeComponent();
            btnMC.IsEnabled = false;
            btnMR.IsEnabled = false;
        }

        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
            memory = 0;
            btnMR.IsEnabled=false;
            btnMC.IsEnabled=false;
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.Contains("."))
                return;
            else
                txtResult.Text += ".";
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string s = btn.Content.ToString();
            txtExp.Text = "";
            //출력창이 0이거나 연산자 버튼이 눌린 후, 메모리 버튼이 눌리거나, afterCalc가 눌리거나
            if (txtResult.Text == "0" || opFlag == true || memFlag == true||afterCalc == true) //aftercalc : 결과 버튼 누른후 새로운 계산위해서 s로 바꿈
            {
                
                if (afterCalc == true)
                    txtExp.Text = "";
                txtResult.Text = s; //s로 바꾸기
                afterCalc = false;
                opFlag = false;
                memFlag = false;
            }


            else
                txtResult.Text += s; //s뒤에 붙이기
        }

        //사칙연산자 클릭
        private void op_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            saved = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + btn.Content.ToString();
            op = btn.Content.ToString();
            opFlag = true;



        }

        private void btnEqul_Click(object sender, RoutedEventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            txtExp.Text += txtExp.Text + "=";
            switch (op)
            {
                case "+":
                    txtResult.Text = (saved + v).ToString();
                    break;
                case "-":
                    txtResult.Text = (saved - v).ToString();
                    break;
                case "x":
                    txtResult.Text = (saved * v).ToString();
                    break;
                case "%":
                    txtResult.Text = (saved / v).ToString();
                    break;
                

            }
            afterCalc = false;

        }

        private void btnPM_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = ((-1) * double.Parse(txtResult.Text)).ToString();
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            double p = Double.Parse(txtResult.Text);
            p = saved * p / 100;
            txtResult.Text = p.ToString();
            //txtExp.Text += txtResult.Text;
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text = "√(" + txtResult.Text + ")";
            else
                txtExp.Text = "√(" + txtExp.Text + ")";
            txtResult.Text=Math.Sqrt(double.Parse(txtResult.Text)).ToString();
        }

        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text = "sqr(" + txtResult.Text + ")";
            else
                txtExp.Text = "sqr(" + txtExp.Text + ")";

            double v = double.Parse(txtResult.Text);
            txtResult.Text = (v * v).ToString();
        }

        private void btnRecip_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text = "1/(" + txtResult.Text + ")";
            else
                txtExp.Text = "1/(" + txtExp.Text + ")";

            double v = double.Parse(txtResult.Text);
            txtResult.Text = (1/v).ToString();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
            txtExp.Text = "";
            saved = 0;
            op = "";
            opFlag = false;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";
            
        }

        private void btnMS_Click(object sender, RoutedEventArgs e)
        {
            memory = double.Parse(txtResult.Text);
            btnMC.IsEnabled = true;
            btnMR.IsEnabled = true;
            memFlag = true;
        }

        private void btnMR_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = memory.ToString();
            memFlag = true;

        }

        private void btnMPlus_Click(object sender, RoutedEventArgs e)
        {
            memory += double.Parse(txtResult.Text);

        }

        private void btnMMinus_Click(object sender, RoutedEventArgs e)
        {
            memory -= double.Parse(txtResult.Text);
        }
    }
}
