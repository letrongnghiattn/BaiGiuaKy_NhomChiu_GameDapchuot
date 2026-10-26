using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_test_2
{
    public partial class TrangChu : Form
    {
        // Khởi tạo SoundPlayer cho trang chủ bằng đường dẫn chuẩn
        System.Media.SoundPlayer bgMusicTrangChu = new System.Media.SoundPlayer(System.IO.Path.Combine(Application.StartupPath, "Resources","nhacnengame.wav"));
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bgMusicTrangChu.Stop();
            Game G = new Game();   
            G.Show();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttXepHang_Click(object sender, EventArgs e)
        {
            
            XepHang XH = new XepHang();
            XH.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            checkBox1.Checked = true;
            try
            {
                bgMusicTrangChu.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể phát nhạc nền trang chủ: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GioiThieu GT = new GioiThieu();
            GT.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HuongDan frm = new HuongDan();
            frm.ShowDialog();
        }

        private void TrangChu_Activated(object sender, EventArgs e)
        {
            
               
            if (checkBox1.Checked)
            {
                try { bgMusicTrangChu.PlayLooping(); } catch { }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try { bgMusicTrangChu.PlayLooping(); } catch { }
            }
            else
            {
                try { bgMusicTrangChu.Stop(); } catch { }
            }
        }
    }
}
