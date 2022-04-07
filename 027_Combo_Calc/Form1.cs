using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _027_Combo_Calc
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds; //학점
        ComboBox[] grds; //성적
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txt1.Text = "인체와구조의기능I";
            txt2.Text = "일반수학I";
            txt3.Text = "데이터사이언스";
            txt4.Text = "설계 및 프로젝트";
            txt5.Text = "중국어I";
            txt6.Text = "비주얼 프로그래밍";
            txt7.Text = "기업가정신";

            titles = new TextBox[] {txt1,txt2,txt3,txt4,txt5,txt6,txt7 };
            crds = new ComboBox[] {crd1,crd2,crd3,crd4,crd5,crd6,crd7 };
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };

            int[] arrCredit = { 1, 2, 3, 4, 5 }; //학점
            List<string> lstGrade = new List<string>
            {
                "A+","A0","B+","B0","C+","C0","D+","D0","F"};
            foreach(var c in crds)
            {
                foreach(var i in arrCredit)
                    c.Items.Add(i);
                c.SelectedItem = 3; //default 3학점
            }
            foreach (var G in grds)
            {
                foreach (var c in lstGrade)
                    G.Items.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            double totalCredit = 0;
            for(int i = 0; i < grds.Length; i++)
            {
                if(grds[i].SelectedItem != null) //성적이 입력된 과목
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString()); //crds = object
                    totalCredit += crd;
                    totalScore += crd* GetGrade(grds[i].SelectedItem.ToString());
                }
              
            }
            txtGrade.Text = (totalScore / totalCredit).ToString("0.0");
        }
        //A+~F까지 학점을 가져오는 메소드
        private double GetGrade(string v)
        {
            double grade;
            if (v == "A+") grade = 4.5;
            else if (v == "A") grade = 4.0;
            else if (v == "B+") grade = 3.5;
            else if (v == "B0") grade = 3.0;
            else if (v == "C+") grade = 2.5;
            else if (v == "C0") grade = 2.0;
            else if (v == "D+") grade = 1.5;
            else if (v == "D0") grade = 1.0;
            else grade = 0;
            return grade;
        }
    }
}
