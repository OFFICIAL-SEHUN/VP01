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

namespace _033_StackPannel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CheckBox[] cbs; //체크박스 배열 초기화
        public MainWindow()
        {
            InitializeComponent();
            cbs = new CheckBox[] { C, C_Plus, C_Sharp, Python, Java };

        }

        private void btnSubmit_click(object sender, RoutedEventArgs e)
        {
            string str = "";
            foreach (var cb in cbs)
            {
                if (cb.IsChecked == true)
                    str += cb.Content + ",";
            }
            MessageBox.Show(str, "Language Prefered");
        }

        private void btnExit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
