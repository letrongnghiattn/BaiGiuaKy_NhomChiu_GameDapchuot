using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Game_test_2
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            holes = new PictureBox[] { picHole1, picHole2, picHole3, picHole4, picHole5, picHole6, picHole7, picHole8, picHole9 };
            mouse.Image = Properties.Resources.mouse;
            mouse.SizeMode = PictureBoxSizeMode.StretchImage;
            mouse.BackColor = Color.Transparent;
            mouse.Visible = false;
            this.Controls.Add(mouse);

            spawnTimer.Interval = 1000;
            spawnTimer.Tick += SpawnTimer_Tick;
            hideTimer.Interval = 800;
            hideTimer.Tick += hideTimer_Tick;

            gametimer.Interval = 1000;

            mouse.MouseDown += mouse_MouseDown;
            foreach (var h in holes)
                h.MouseDown += Hole_MouseDown;
            this.FormClosing += (s, ev) => StopMole();

            // Khởi chạy nhạc nền bằng MediaPlayer 
            bgMusic.Open(new Uri(System.IO.Path.Combine(Application.StartupPath, "Resources\\nhacnengame.wav"), UriKind.Absolute));
            bgMusic.MediaEnded += (s, ev) => {
                bgMusic.Position = TimeSpan.Zero;
                bgMusic.Play();
            };
            bgMusic.Play();

            // Mở sẵn file tiếng đập chuột bằng MediaPlayer để phát song song
            hitSound.Open(new Uri(System.IO.Path.Combine(Application.StartupPath, "Resources\\bamboo-hit-sound-effect.wav"), UriKind.Absolute));
        }

        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            if (isPaused) return;
            int index;
            do
            {
                index = rand.Next(holes.Length);
            } while (index == currentIndex);

            currentIndex = index;
            hitThisTurn = false;
            PictureBox hole = holes[currentIndex];
            mouse.Location = this.PointToClient(hole.PointToScreen(Point.Empty));
            mouse.Visible = true;
            mouse.Size = hole.Size;
            mouse.BringToFront();

            hideTimer.Stop();
            hideTimer.Start();
        }

        private void hidemole()
        {
            mouse.Visible = false;
        }

        private void mouse_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPaused) return;
            if (e.Button != MouseButtons.Left) return;
            if (hitThisTurn) return;

            hitThisTurn = true;
            hideTimer.Stop();
            hidemole();

            
            try
            {
                hitSound.Position = TimeSpan.Zero;
                hitSound.Play();
            }
            catch { }

            score++;
            lblScore.Text = "Điểm: " + score;
        }

        public void StartMole()
        {
            score = 0;
            isPaused = false;
            lblScore.Text = "Điểm: 0";

            timeLeft = 30;
            lblTime.Text = "Time: " + timeLeft + "s";

            currentIndex = -1;
            spawnTimer.Start();
            gametimer.Start();
        }

        public void StopMole()
        {
            spawnTimer.Stop();
            hideTimer.Stop();
            gametimer.Stop();
            hidemole();
            bgMusic.Stop();
        }

        private void hideTimer_Tick(object sender, EventArgs e)
        {
            hideTimer.Stop();
            hidemole();
        }

        private void Hole_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (!spawnTimer.Enabled) return;
            if (score > 0) score--;
            lblScore.Text = "Điểm: " + score;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDifficulty.SelectedIndex)
            {
                case 0: // Dễ
                    spawnTimer.Interval = 1500;
                    hideTimer.Interval = 1200;
                    break;
                case 1: // Trung bình
                    spawnTimer.Interval = 800;
                    hideTimer.Interval = 500;
                    break;
                case 2: // Khó
                    spawnTimer.Interval = 500;
                    hideTimer.Interval = 300;
                    break;
            }
        }

        private void tableMenu_Paint(object sender, PaintEventArgs e) { }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttChoiLai_Click(object sender, EventArgs e)
        {
            this.Close();
            Game G = new Game();
            G.Show();
        }

        PictureBox[] holes;
        PictureBox mouse = new PictureBox();
        Random rand = new Random();
        Timer spawnTimer = new Timer();
        Timer hideTimer = new Timer();
        int currentIndex = -1;
        bool hitThisTurn = false;
        int score = 0;
        int timeLeft = 30;
        bool isPaused = false;

        
        System.Windows.Media.MediaPlayer bgMusic = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer hitSound = new System.Windows.Media.MediaPlayer();

        private void bttVao_Click(object sender, EventArgs e)
        {
            StartMole();
        }

        

        private void lblTime_Click(object sender, EventArgs e) { }

        public class ScoreRecord
        {
            public string Ten { get; set; }
            public int Diem { get; set; }
        }

        private void LuuThanhTich(int currentScore)
        {
            string tenNguoiChoi = "Người chơi";
            using (Form prompt = new Form())
            {
                prompt.Width = 400;
                prompt.Height = 180;
                prompt.Text = "Kết thúc trò chơi";
                prompt.StartPosition = FormStartPosition.CenterScreen;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;

                Label textLabel = new Label() { Left = 20, Top = 20, Text = "Nhập họ tên của bạn để lưu thành tích:", Width = 340 };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340, Text = "Người chơi" };
                Button confirmation = new Button() { Text = "Lưu", Left = 260, Top = 90, Width = 100, DialogResult = DialogResult.OK };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                if (prompt.ShowDialog() == DialogResult.OK)
                {
                    tenNguoiChoi = inputBox.Text;
                }
            }

            if (string.IsNullOrWhiteSpace(tenNguoiChoi))
            {
                tenNguoiChoi = "Ẩn danh";
            }

            string filePath = "xep_hang.txt";
            List<ScoreRecord> danhSach = new List<ScoreRecord>();

            if (System.IO.File.Exists(filePath))
            {
                foreach (var line in System.IO.File.ReadAllLines(filePath))
                {
                    var parts = line.Split('|');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int diem))
                    {
                        danhSach.Add(new ScoreRecord { Ten = parts[0], Diem = diem });
                    }
                }
            }

            danhSach.Add(new ScoreRecord { Ten = tenNguoiChoi, Diem = currentScore });
            danhSach = danhSach.OrderByDescending(x => x.Diem).ToList();

            var linesToSave = danhSach.Take(10).Select(x => $"{x.Ten}|{x.Diem}").ToArray();
            System.IO.File.WriteAllLines(filePath, linesToSave);
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTime.Text = "Time: " + timeLeft + "s";
            }
            else
            {
                StopMole();
                LuuThanhTich(score);
                MessageBox.Show("Hết giờ! Trò chơi kết thúc. Tổng điểm của bạn: " + score, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gametimer.Enabled || isPaused)
            {
                isPaused = !isPaused;

                if (isPaused)
                {
                    spawnTimer.Stop();
                    hideTimer.Stop();
                    gametimer.Stop();
                    mouse.Visible = false;
                    bgMusic.Pause();  // Tạm dừng nhạc nền 

                    MessageBox.Show("Trò chơi đang được tạm dừng. Nhấn OK để tiếp tục!", "Tạm dừng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    isPaused = false;
                    spawnTimer.Start();
                    hideTimer.Start();
                    gametimer.Start();
                    bgMusic.Play(); // Tiếp tục phát nhạc từ đoạn đang dừng
                }
            }
        }
    }
}