using DevExpress.XtraBars.Docking2010.Dragging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TN_CSDLPT
{
    public partial class tiktok : Form
    {
        public tiktok()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        //coutom
        private void panel10_Click(object sender, EventArgs e)
        {
            //label22.Visible = true;
            textBox2.Visible = true;
            label13.Visible = false;
            //label21.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //label22.Visible = true;
            textBox2.Visible = true;
            label13.Visible = false;
            //label21.Visible = false;

        }

        private void tiktok_Load(object sender, EventArgs e)
        {
            label21.Visible = true;

            label13.Visible = true;
            textBox2.Visible = false;
            textBox2.Visible = false;
            button5.BackColor = Color.FromArgb(254, 44, 85);

        }

       


        private void panel2_Paint(object sender, PaintEventArgs e)
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
        //Charge
        private void button5_Click(object sender, EventArgs e)
        {
            Program.Tien = int.Parse(textBox2.Text.ToString().Trim());
            Program.Coin = textBox2.Text.ToString().Trim();
            Program.Id = textBox1.Text.ToString().Trim();

            showForm(typeof(Coutums));
            //showForm(typeof(tiktok));
        }

        public void HienThi()
        {
            textBox2.Visible = false;
            label13.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
