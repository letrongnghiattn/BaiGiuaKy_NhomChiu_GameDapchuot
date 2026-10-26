using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Thư viện để làm việc với file txt
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_test_2
{
    public partial class XepHang : Form
    {
        public XepHang()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
        }

        // Tạo cấu trúc lưu trữ thông tin điểm số
        public class ScoreRecord
        {
            public string Ten { get; set; }
            public int Diem { get; set; }
        }

        private void XepHang_Load(object sender, EventArgs e)
        {
            LoadBangXepHang();
        }

        private void LoadBangXepHang()
        {
            string filePath = "xep_hang.txt";
            dataGridView1.Rows.Clear(); 

            try // Bọc trong try-catch để bắt lỗi nếu file txt bị khóa hoặc lỗi định dạng
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    List<ScoreRecord> danhSach = new List<ScoreRecord>();

                    // Đọc từng dòng từ file txt và tách dữ liệu thành Tên và Điểm
                    foreach (var line in lines)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 2 && int.TryParse(parts[1], out int diem))
                        {
                            danhSach.Add(new ScoreRecord { Ten = parts[0], Diem = diem });
                        }
                    }

                    // Sắp xếp điểm số theo thứ tự giảm dần 
                    danhSach = danhSach.OrderByDescending(x => x.Diem).ToList();

                    // Đổ dữ liệu vào đúng các cột đã thiết kế sẵn trên giao diện (STT, Tên, Điểm)
                    int stt = 1;
                    foreach (var item in danhSach)
                    {
                        dataGridView1.Rows.Add(stt.ToString(), item.Ten, item.Diem.ToString());
                        stt++;
                    }
                }
                else
                {
                    // Nếu chưa có file dữ liệu, hiển thị thông báo mẫu
                    dataGridView1.Rows.Add("1", "Chưa có dữ liệu thành tích", "0");
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi xảy ra khi đọc file, hiển thị bảng cảnh báo thay vì văng game
                MessageBox.Show("Lỗi khi đọc file xếp hạng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.Rows.Add("1", "Lỗi tải dữ liệu", "0");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}