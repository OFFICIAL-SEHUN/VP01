using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _047_FormClock
{
    public partial class Form1 : Form
    {
        //필드 , 속성
        Graphics g;
        bool aClock_Flag = false;
        Point center; //중심점
        double radius; //반지름
        int hourHand; //시침의 길이
        int minHand; //분침
        int secHand; //초침
        const int clientSize = 300;
        const int clockSize = 200;
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(clientSize, clientSize+menuStrip1.Height); //메뉴스트립 높이 더 함 
            this.Text = "Form Clock";
            panel1.BackColor = Color.Gray;

            g = panel1.CreateGraphics();
            aClockSetting();
            TimerSetting();
        }

        private void TimerSetting()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;
            panel1.Refresh(); //패널지우기
            if (aClock_Flag == true)
            {

                DrawClockFace(); //시계판

                //시계바늘 그리기
                double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
                double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
                double radSec = c.Second * 6 * Math.PI / 180;
                DrawHands(radHr, radMin, radSec);
            }
            else
            {
                Font fDate = new Font("맑은 고딕", 12, FontStyle.Bold);
                Font fTime = new Font("맑은 고딕", 32, FontStyle.Bold|FontStyle.Italic);
                Brush bDate = Brushes.SkyBlue;
                Brush bTime = Brushes.White;

                string date = DateTime.Today.ToString("D");
                string time = string.Format("{0:D2}:{1:D2}:{2:D2}",c.Hour,c.Minute,c.Second);
                g.DrawString(date, fDate, bDate, new Point(50, 120));
                g.DrawString(time,fTime,bTime,new Point(50, 150));
            }
        }

        private void DrawHands(double radHr, double radMin, double radSec)
        {
            //시침
            DrawLine(0, 0,
            (int)(hourHand * Math.Sin(radHr)), (int)(hourHand * Math.Cos(radHr)),Brushes.HotPink,5);
            
            //분침
            DrawLine(0, 0,
            (int)(minHand * Math.Sin(radMin)), (int)(minHand * Math.Cos(radMin)),Brushes.Linen,4);
            
            //초침(현재 시간의 좌표를 각도를 이용하여 구하자)
            DrawLine(0,0,
            (int)(secHand * Math.Sin(radSec)),(int)(secHand* Math.Cos(radSec)),Brushes.Gold,3);

            //배꼽
            int coreSize = 16;
            Rectangle r = new Rectangle(
                center.X - coreSize / 2, center.Y - coreSize / 2, coreSize, coreSize);
            g.FillEllipse(Brushes.White, r);
            g.DrawEllipse(new Pen(Brushes.Bisque, 3), r);
               
        }

        private void DrawLine(int x1, int y1, int x2, int y2,Brush brush, int thick)
        {
            Pen p = new Pen(brush, thick);
            g.DrawLine(p, center.X+x1, center.Y-y1, center.X+x2, center.Y-y2);
        }

        private void DrawClockFace()
        {
            Pen pen = new Pen(Brushes.White, 15);
            g.DrawEllipse(pen, center.X - clockSize/2, center.Y-clockSize/2, 180, 180);
        }

        private void aClockSetting()
        {
            center = new Point(clientSize/2 , clientSize/2);
            radius = clockSize / 2;
            hourHand = (int)(radius * 0.45);
            minHand = (int)(radius * 0.55);
            secHand = (int)(radius * 0.65);

        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClock_Flag = true;

        }

        private void 디지털ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClock_Flag = false;
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
