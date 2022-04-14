using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _025_ListBox
{
    public partial class Form1 : Form
    {
        public Form1() //생성자 함수 - 객체생성시 자동실행 / form이 뜨자마자 하는 작업은 생성자함수에서 작업하기
        {
            InitializeComponent(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        { //(2)Form1에 작성
            listBox2.Items.Add("오클랜드(뉴질랜드)");
            listBox2.Items.Add("오사카(일본)");
            listBox2.Items.Add("아델레이드(호주)");
            listBox2.Items.Add("웰링턴(뉴질랜드)");
            listBox2.Items.Add("도쿄(일본)");
            listBox2.Items.Add("퍼스(호주)");
            listBox2.Items.Add("취리히(스위스)");
            listBox2.Items.Add("제너바(스위스)");
            listBox2.Items.Add("멜버른(호주)");
            listBox2.Items.Add("브리즈번(호주)");
            //(3)DataSource 사용법
            List<string> happiness = new List<string>() //class 의 형태
            {
                "핀란드","덴마크","아이슬란드","스위스","네덜란드","룩셈부르크","스웨덴","노르웨이","이스라엘","뉴질랜드"
            };
            listBox3.DataSource = happiness;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //object x = new object(); //class// object는 모든 클래스의 조상. 
            //ListBox l = (ListBox)sender; //sender를 ListBox형으로 캐스팅
            //ListBox l = sender as ListBox ; //sender를 ListeBox형으로 하겠다.
            ListBox l = sender as ListBox;
            txtSIndex1.Text = l.SelectedIndex.ToString();
            txtSItem1.Text = l.SelectedItem.ToString();
            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            txtSIndex2.Text = l.SelectedIndex.ToString();
            txtSItem2.Text = l.SelectedItem.ToString();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            txtSIndex3.Text = l.SelectedIndex.ToString();
            txtSItem3.Text = l.SelectedItem.ToString();
        }

    } //List Box 작성하기 1. form1생성자안에 작성(최적) 2. Form1_Load에 작성 3. 속성창의 문자열 컬렉션으로 작성
}
