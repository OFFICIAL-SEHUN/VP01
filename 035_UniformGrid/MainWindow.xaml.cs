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

namespace _035_UniformGrid
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
            
            
            for (int height = 0; height <8; height++)
            {
                Rectangle r1 = new Rectangle();
                chess_Board.Children.Add(r1);
                Rectangle r2 = new Rectangle();
                chess_Board.Children.Add(r2);
                for (int width = 0; width <8; width++)
                {
                    
                    
                    if (width + height % 2 == 0)
                    {
                        r1.Fill = Brushes.Black;
                        

                    }
                    else
                    {
                        
                        r2.Fill = Brushes.Red;
                        
                    }
                }
            }
        }
    }
}
