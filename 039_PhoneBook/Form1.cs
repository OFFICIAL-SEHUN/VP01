using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tpgns\Documents\StudentDB.accdb
namespace _039_PhoneBook
{
    public partial class Form1 : Form
    {
        string connStr = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\tpgns\Documents\StudentDB.accdb";
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;
        public Form1()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            if(conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();

            }
            string sql = "SELECT * FROM StudentTable";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string item = "";
                item += reader["ID"].ToString() + "\t";
                item += reader["SID"].ToString() + "\t";
                item += reader["SName"].ToString() + "\t";
                item += reader["Phone"].ToString();

                lstStudent.Items.Add(item);
            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        private void lstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            //ListBox lb2 = (ListBox) sender;
            if (lb.SelectedItem == null)
                return;
            string[] s = lb.SelectedItem.ToString().Split('\t');
            txtID.Text = s[0];
            txtSID.Text = s[1];
            txtSName.Text = s[2];
            txtPhone.Text = s[3];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSName.Text == "" || txtSID.Text == "" || txtPhone.Text == "")
                return;
            connopen();
            //sql문장만들기
            string sql = string.Format("INSERT INTO StudentTable(SID,SName,Phone)" +
                "VALUES({0},'{1}','{2}')", txtSID.Text, txtSName.Text, txtPhone.Text);
            //MessageBox.Show(sql);
            comm = new OleDbCommand(sql, conn);
            int x = comm.ExecuteNonQuery();
            if (x == 1) MessageBox.Show("삽입성공!");
            connClose();
        }

        private void connClose()
        {
            conn.Close();
            conn = null;

            lstStudent.Items.Clear();
            DisplayStudents();
        }

        private void connopen()
        {
            //db연결
            conn = new OleDbConnection(connStr);
            conn.Open();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                return;
            connopen();
            string sql = string.Format("DELETE FROM StudentTable WHERE ID = {0}",txtID.Text);

            comm = new OleDbCommand(sql, conn);
            int x=comm.ExecuteNonQuery();
            if (x == 1) MessageBox.Show("정상적으로 제거 되었습니다.");
            connClose();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (txtID.Text == "" && txtSName.Text == "" && txtPhone.Text == "") return;
            connopen();
            string sql = string.Format("SELECT * FROM StudentTable WHERE ");
            if (txtSID.Text != "")
                sql += "SID = "+txtSID.Text;
            else if(txtSName.Text != "")
                sql += "SName = '"+ txtSName.Text +"'";
            else if(txtPhone.Text != "")
                sql += "Phone = '" + txtPhone.Text +"'";

            comm = new OleDbCommand(sql, conn);

            //리스트박스 지우기
            lstStudent.Items.Clear();

            //DisplayStudent에서 복서해온부분
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string item = "";
                item += reader["ID"].ToString() + "\t";
                item += reader["SID"].ToString() + "\t";
                item += reader["SName"].ToString() + "\t";
                item += reader["Phone"].ToString();

                lstStudent.Items.Add(item);
            }
            reader.Close();

            conn.Close();
            conn = null;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            lstStudent.Items.Clear();
            DisplayStudents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connopen();

            string sql = string.Format("UPDATE StudentTable SET "+
                "SID = {0}, SName = '{1}', Phone = '{2}' WHERE ID = {3}",txtSID.Text,txtSName.Text,txtPhone.Text,txtID.Text);
            comm = new OleDbCommand(sql,conn);
            int x = comm.ExecuteNonQuery();
            if (x == 1) MessageBox.Show("수정 성공");
            connClose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSID.Text = "";
            txtSName.Text = "";
            txtPhone.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
