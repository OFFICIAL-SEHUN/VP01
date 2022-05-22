using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace _040_WPFLogin
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Csharp\040_WPFLogin\myLogin.mdf;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = string.Format("SELECT COUNT(*) FROM LoginTable WHERE UserName='{0}' AND Password ='{1}'", txtUserName.Text, txtPassword.Password);

            SqlCommand comm = new SqlCommand(sql, conn);
            int count = Convert.ToInt32(comm.ExecuteScalar()); //리턴되는 값의 첫번재 값 받음 > object 값 리턴이기때문에 32비트 정수형으로 convert
            if (count == 1)
            {
                MessageBox.Show("Login 성공");
            }
            else
                MessageBox.Show("Login 실패");
            conn.Close();
        }
    }
}
