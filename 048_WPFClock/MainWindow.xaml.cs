using System.Windows;
using System.Drawing;
using System;
using System.Windows.Threading;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _048_WPFClock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        bool aClock_Flag = false;
        Point center; //중심점
        double radius; //반지름
        int hourHand; //시침의 길이
        int minHand; //분침
        int secHand; //초침
        DispatcherTimer timer = new DispatcherTimer();
        private bool ms_flag =false;

        public MainWindow()
        {
            InitializeComponent();

            aClockSetting();
            timerSetting();
        }

        private void timerSetting()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100); //0.1초
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;

            if (aClock_Flag == true)
            { //analog
                canvas1.Children.Clear();
                DrawClockFace();
                double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
                double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
                double radSec = (c.Second * 6 + c.Millisecond * 6.0 / 1000) * Math.PI / 180;

                DrawHands(radHr, radMin, radSec);
            }
            else
            { //digital
                canvas1.Children.Clear();
                string x = "";

                txtDate.Text = DateTime.Today.ToString("D");
                x = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}", c.Hour, c.Minute, c.Second, c.Millisecond);
                txtTime.Text = x;

            }

        }

        private void DrawHands(double radHr, double radMin, double radSec)
        {
            //시침
            DrawLine(0, 0,
            (int)(hourHand * Math.Sin(radHr)), (int)(hourHand * Math.Cos(radHr)), Brushes.HotPink, 5);

            //분침
            DrawLine(0, 0,
            (int)(minHand * Math.Sin(radMin)), (int)(minHand * Math.Cos(radMin)), Brushes.Linen, 4);

            //초침(현재 시간의 좌표를 각도를 이용하여 구하자)
            DrawLine(0, 0,
            (int)(secHand * Math.Sin(radSec)), (int)(secHand * Math.Cos(radSec)), Brushes.Gold, 3);

            //배꼽
            int coresize = 16;
            Ellipse core = new Ellipse();
            core.Margin = new Thickness(center.X-coresize/2,center.Y -coresize/2,0,0);

            core.Stroke = Brushes.SteelBlue;
            core.StrokeThickness = 3;
            core.Fill = Brushes.LightSteelBlue;
            core.Width = 20;
            core.Height = 20;
            canvas1.Children.Add(core);
        }

        private void DrawLine(double x1, double y1, int x2, int y2, SolidColorBrush brush, int thick)
        {
            Line line = new Line();
            line.X1 = x1; line.Y1 = -y1; line.X2 = x2; line.Y2 = -y2;
            line.Stroke = brush;
            line.StrokeThickness = thick;
            line.Margin = new Thickness(center.X,center.Y,0,0);
            line.StrokeStartLineCap = PenLineCap.Round;
            canvas1.Children.Add(line);
        }
        
        private void DrawClockFace()
        {
            aClock.Stroke = Brushes.LightSteelBlue;
            aClock.StrokeThickness = 30;
            canvas1.Children.Add(aClock);
        }

        private void aClockSetting()
        {
            center = new Point(canvas1.Width / 2, canvas1.Height / 2);
            radius = canvas1.Width / 2;
            hourHand = (int)(radius * 0.45);
            minHand = (int)(radius * 0.55);
            secHand = (int)(radius * 0.65);

        }

        private void MS_Click(object sender, RoutedEventArgs e)
        {
            ms_flag = true;
            timer.Interval = new TimeSpan(0, 0, 0, 0,10); //0.1초
        }

        private void aClock_Click(object sender, RoutedEventArgs e)
        {
            aClock_Flag  = true;
            txtDate.Text = "";
            txtTime.Text = "";

        }

        private void dClock_Click(object sender, RoutedEventArgs e)
        {
            aClock_Flag = false;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sec_Click(object sender, RoutedEventArgs e)
        {
            ms_flag = false;
            timer.Interval = new TimeSpan(0, 0, 0, 1); //1초
        }
    }
}
