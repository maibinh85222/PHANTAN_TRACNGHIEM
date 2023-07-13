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
    public partial class PayMent : Form
    {
        public PayMent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        private void PayMent_Load(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(254, 44, 85);
            //button1.Enabled = false;
            label2.Text = "You have deposited " + Program.Coin + " coins.You can use Coins to send";
        }

        public void HienThi()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.frmChinh.HienThi();
            Close();
        }
    }
}
