using System;
using System.Windows.Forms;
using BUS;
using DAL.Models;

namespace Student
{
    public partial class frmStudent : Form
    {
        private StudentService studentService = new StudentService(); // Khởi tạo đối tượng BUS

        public frmStudent()
        {
            InitializeComponent();
            LoadStudentData();
        }

        // 📚 Load dữ liệu sinh viên lên DataGridView
        private void LoadStudentData()
        {
            dgvStudents.DataSource = studentService.GetAllStudents();
        }

        // ✅ Thêm hoặc cập nhật thông tin sinh viên
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    // Retrieve input values
                    int studentID = int.Parse(txtStudentID.Text);
                    string fullName = txtFullName.Text;
                    int? majorID = chkUnregisterMajor.Checked
                        ? null
                        : (cboFaculty.SelectedItem != null ? (int?)int.Parse(cboFaculty.SelectedItem.ToString()) : null);
                    double averageScore = double.Parse(txtGPA.Text);

                    // Create a new Student object
                    var student = new DAL.Models.Student
                    {
                        StudentID = studentID,
                        FullName = fullName,
                        MajorID = majorID,
                        AverageScore = averageScore
                    };

                    // Save the student object using the service layer
                    studentService.SaveStudent(student);

                    MessageBox.Show("Thông tin sinh viên đã được lưu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentData();
                    ClearInputs();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Lỗi định dạng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ✅ Xóa thông tin sinh viên
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStudentID.Text) && int.TryParse(txtStudentID.Text, out int studentID))
            {
                bool result = studentService.DeleteStudent(studentID);

                if (result)
                {
                    MessageBox.Show("Đã xóa sinh viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên hợp lệ để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ✅ Kiểm tra thông tin đầu vào
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtStudentID.Text) || string.IsNullOrEmpty(txtFullName.Text) ||
                cboFaculty.SelectedItem == null || string.IsNullOrEmpty(txtGPA.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtGPA.Text, out double gpa) || gpa < 0 || gpa > 10)
            {
                MessageBox.Show("Điểm trung bình không hợp lệ (0-10)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ✅ Xóa các ô nhập liệu
        private void ClearInputs()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            cboFaculty.SelectedIndex = -1;
            txtGPA.Clear();
            chkUnregisterMajor.Checked = false;
        }

        // ✅ Sự kiện chọn dòng trong DataGridView
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                cboFaculty.Text = row.Cells["MajorID"]?.Value?.ToString() ?? "N/A";
                txtGPA.Text = row.Cells["AverageScore"].Value.ToString();
                chkUnregisterMajor.Checked = row.Cells["MajorID"].Value == null;
            }
        }

        // ✅ Hiển thị danh sách sinh viên chưa đăng ký chuyên ngành
        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnregisterMajor.Checked)
            {
                dgvStudents.DataSource = studentService.GetStudentsWithoutMajor();
            }
            else
            {
                LoadStudentData();
            }
        }
    }
}
