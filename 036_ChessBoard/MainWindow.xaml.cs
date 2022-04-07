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

namespace _036_ChessBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            chess_Board.Rows = 8;
            chess_Board.Columns = 8;
            
            for (int k = 1; k < 9; k++) //줄별로
            {
                
                if (k % 2 == 0)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Rectangle r1 = new Rectangle();
                            r1.Fill = Brushes.Black;
                            chess_Board.Children.Add(r1);
                        }
                        else
                        {
                            Rectangle r1 = new Rectangle();
                            r1.Fill = Brushes.Red;
                            chess_Board.Children.Add(r1);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Rectangle r1 = new Rectangle();
                            r1.Fill = Brushes.Red;
                            chess_Board.Children.Add(r1);
                        }
                        else
                        {
                            Rectangle r1 = new Rectangle();
                            r1.Fill = Brushes.Black;
                            chess_Board.Children.Add(r1);
                        }
                    }
                }

            }
            
            
        }
    }
}
