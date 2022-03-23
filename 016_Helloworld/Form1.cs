using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_Helloworld
{
    public partial class Form1 : Form //Form을 상속받는 Form1
    {
        public Form1() //객체 생성시 생성자 생성
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //버튼 클릭 이벤트 호출 > 함수 실행
        {
            label1.Text = "Hello! Windows Forms Application!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //this : Form1 / C#은 포인터가 없어서 this '.' 으로 작성
        }
    }
}
