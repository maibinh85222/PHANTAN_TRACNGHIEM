using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class Coutums : Form
    {
        public Coutums()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(254, 44, 85);
        }

        private void Coutums_Load(object sender, EventArgs e)
        {
            label4.Text = Program.Id;
            

            label5.Text = Program.Coin + " Coins";
            float tien = Program.Tien * 0.012f;
            string TIEN = tien.ToString("0.00").Split('.')[1];

            label7.Text = "$ " + tien;
            label8.Text = "$ " + tien;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void showForm(Type frmType)
        {
            Form frm = this.CheckExists(frmType);
            if (frm != null) frm.Activate();
            else
            {
                Form f = (Form)Activator.CreateInstance(frmType);

                //gán cha của formDangNhap là form hiện tại và show lên
                //f.MdiParent = this;
                f.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gainsboro;
            label9.Visible = label10.Visible = button1.Visible= button2.Visible = panel1.Visible = panel2.Visible = panel3.Visible = panel5.Visible = panel6.Visible = false;
            // Hiển thị hộp thoại thông báo
            //MessageBox.Show("Đã hoàn tất thanh toán/n Bạn có thể dùng xu để tặng quà ảo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            timer1.Start();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Thời gian.
        private int s = 1;
        private int thoigian = 1;
       // private MessageBox loadingMessageBox;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == 0)
            {
                if (thoigian != 0)
                {
                    thoigian--;
                    s = 59;
                }
            }
            button1.Text = "Loading...";
            button5.Visible = true;
           // MessageBox.Show("Loading...");

            if (thoigian == 0 && s == 0)
            {
                label9.Visible = label10.Visible = button1.Visible = button2.Visible = panel1.Visible = panel2.Visible = panel3.Visible = panel5.Visible = panel6.Visible = true;
                button5.Visible = false;
                timer1.Stop();
                showForm(typeof(PayMent));
                button1.Text = "Pay now";
                this.Close();
            }
        }
    }
}
