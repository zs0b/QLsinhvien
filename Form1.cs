using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bai5.BUS;
using Bai5.DAL.Entities;

namespace Bai5.GUI
{
    public partial class Form1 : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Cấu hình DataGridView
                setGridViewStyle(dataGridView_data);

                // Thêm cột vào DataGridView (nếu chưa có)
                if (dataGridView_data.Columns.Count == 0)
                {
                    dataGridView_data.Columns.Add("StudentID", "Mã số sinh viên");
                    dataGridView_data.Columns.Add("FullName", "Họ tên");
                    dataGridView_data.Columns.Add("FacultyName", "Tên khoa");
                    dataGridView_data.Columns.Add("AverageScore", "Điểm trung bình");
                    dataGridView_data.Columns.Add("MajorName", "Chuyên ngành");
                }

                // Lấy danh sách từ service
                var listFacultys = facultyService.GetAll(0);
                var listStudents = studentService.GetAll();

                // Đưa dữ liệu vào combobox và DataGridView
                FillFacultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng không nhấp vào header của cột
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = dataGridView_data.Rows[e.RowIndex];

                    // Hiển thị thông tin từ dòng vào các điều khiển
                    textBox_masinhvien.Text = row.Cells["StudentID"].Value.ToString();
                    textBox_hoten.Text = row.Cells["FullName"].Value.ToString();
                    comboBox_khoa.SelectedItem = row.Cells["Faculty"].Value.ToString();
                    textBox_diemtrungbinh.Text = row.Cells["GPA"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin sinh viên: " + ex.Message);
            }
        }





        private void FillFacultyCombobox(List<Faculty> listFacultys)
        {
            // Thêm mục trống để người dùng chọn tất cả
            listFacultys.Insert(0, new Faculty { FacultyID = 0, FacultyName = "Tất cả" });

            // Gán danh sách vào ComboBox
            this.comboBox_khoa.DataSource = listFacultys;
            this.comboBox_khoa.DisplayMember = "FacultyName";
            this.comboBox_khoa.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            // Xóa các hàng cũ trong DataGridView
            dataGridView_data.Rows.Clear();

            // Duyệt qua danh sách sinh viên và thêm từng hàng
            foreach (var item in listStudent)
            {
                int index = dataGridView_data.Rows.Add();
                dataGridView_data.Rows[index].Cells[0].Value = item.StudentID; // Mã số sinh viên
                dataGridView_data.Rows[index].Cells[1].Value = item.FullName;  // Họ tên

                // Hiển thị tên khoa nếu có
                if (item.Faculty != null)
                    dataGridView_data.Rows[index].Cells[2].Value = item.Faculty.FacultyName;

                // Hiển thị điểm trung bình
                dataGridView_data.Rows[index].Cells[3].Value = item.AverageScore.ToString("0.0");

                // Hiển thị chuyên ngành nếu có
                if (item.Major != null)
                    dataGridView_data.Rows[index].Cells[4].Value = item.Major.Name;

                // Hiển thị ảnh đại diện
                ShowAvatar(item.Avatar);
            }
        }


        private void ShowAvatar(string ImageName)
        {
            try
            {
                if (string.IsNullOrEmpty(ImageName))
                {
                    pictureBox_anhdaidien.Image = null; // Không có ảnh
                }
                else
                {
                    // Xác định đường dẫn đầy đủ đến thư mục chứa ảnh
                    string parentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string imagePath = Path.Combine(parentDirectory, "Images", ImageName);

                    if (File.Exists(imagePath))
                    {
                        pictureBox_anhdaidien.Image = Image.FromFile(imagePath);
                        pictureBox_anhdaidien.Refresh();
                    }
                    else
                    {
                        MessageBox.Show($"Ảnh không tồn tại: {imagePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị ảnh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.DefaultCellStyle.SelectionForeColor = Color.White;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgview.DefaultCellStyle.Font = new Font("Arial", 10);
            dgview.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void button_uploadimage_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở hộp thoại chọn file hình ảnh
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Hạn chế loại file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file đã chọn
                    string filePath = openFileDialog.FileName;

                    // Lấy định dạng file (đuôi file)
                    string fileExtension = Path.GetExtension(filePath).ToLower();

                    // Lấy mã sinh viên từ textbox hoặc biến thích hợp
                    string studentID = "1234567890";  // Giả sử bạn lấy studentID từ trường nhập liệu

                    // Đặt tên file mới là {studentID}.{fileExtension}
                    string newFileName = $"{studentID}{fileExtension}";

                    // Đường dẫn mới trong thư mục Images
                    string imageDirectory = Path.Combine(Application.StartupPath, "Images");

                    // Nếu thư mục chưa tồn tại, tạo thư mục
                    if (!Directory.Exists(imageDirectory))
                    {
                        Directory.CreateDirectory(imageDirectory);
                    }

                    // Đường dẫn đầy đủ đến file ảnh mới
                    string newFilePath = Path.Combine(imageDirectory, newFileName);

                    // Copy file vào thư mục Images
                    File.Copy(filePath, newFilePath, true);  // 'true' để ghi đè nếu đã có file

                    // Cập nhật tên file vào cơ sở dữ liệu (giả sử bạn đã có dịch vụ để thực hiện điều này)
                    studentService.UpdateStudentAvatar(studentID, newFileName);

                    // Hiển thị ảnh lên PictureBox
                    pictureBox_anhdaidien.Image = Image.FromFile(newFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox_chuadangky_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var listStudents = new List<Student>();

                // Kiểm tra trạng thái của checkbox
                if (this.checkBox_chuadangky.Checked)
                {
                    // Lấy danh sách sinh viên chưa đăng ký chuyên ngành
                    listStudents = studentService.GetAllHasNoMajor();
                }
                else
                {
                    // Lấy tất cả sinh viên
                    listStudents = studentService.GetAll();
                }

                // Gọi phương thức BindGrid để hiển thị dữ liệu
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi trong quá trình xử lý
                MessageBox.Show($"Lỗi khi tải danh sách sinh viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
