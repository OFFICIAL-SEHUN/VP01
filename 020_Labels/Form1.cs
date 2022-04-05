using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_Labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Text = "라파엘로, 아테네 학당";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "라파엘로 산치오 다 우르비노, 르네상스 시대 이탈리아의 예술가";

            label2.Text = "라파엘로 산치오 다 우르비노(이탈리아어: Raffaello Sanzio da Urbino, 1483년12월 10일 ~ 1520년 8월 20일)는 르네상스 시대 이탈리아의 예술가·화가이며, 흔히 라파엘로(Raffaello)라고 불린다. 《아테네 학당》이 특히 유명하다. <아테네 학당>은 에피쿠로스, 피타고라스, 안티스테네스 등 고대 그리스의 학자가 학당에 모인 것을 상상해서 그린 그림이다.";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
