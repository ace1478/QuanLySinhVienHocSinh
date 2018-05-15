using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNTA.DTO;
using TNTA.DAO;

namespace TNTA.GUI
{
    public partial class UC_SinhVien : UserControl
    {
        private Account Acc;
        private List<SinhVien> ListSV;
        internal Account Acc1
        {
            get
            {
                return Acc;
            }

            set
            {
                Acc = value;
            }
        }
        private int trangthai = -1;
        public UC_SinhVien()
        {
            InitializeComponent();
        }

        private void UC_SinhVien_Load(object sender, EventArgs e)
        {
            LoadForm();
            DataGridViewColumn clTenLop = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            clTenLop.CellTemplate = cell;
            clTenLop.Name = "TenLop";
            clTenLop.Width = 200;
            clTenLop.HeaderText = "Tên Lớp";
            dtgvSinhVien.Columns.Add(clTenLop);
            for (int i = 0; i < SinhVienDAO.LoadDSSinhVien().Count; i++)
            {


                dtgvSinhVien.Rows[i].Cells["TenLop"].Value = LopDAO.LoadTenLop((int)dtgvSinhVien.Rows[i].Cells["MaLop"].Value);
            }
        }
        public void LoadForm()
        {
            ListSV = SinhVienDAO.LoadDSSinhVien();
            dtgvSinhVien.DataSource = ListSV;

            dtgvSinhVien.Columns["HoVaTen"].HeaderText = "Họ và Tên";
            dtgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dtgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dtgvSinhVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dtgvSinhVien.Columns["MaLop"].HeaderText = "Mã Lớp";
            dtgvSinhVien.Columns["HoVaTen"].Width = 150;
            dtgvSinhVien.Columns["NgaySinh"].Width = 100;
            dtgvSinhVien.Columns["GioiTinh"].Width = 100;
            dtgvSinhVien.Columns["SDT"].Width = 100;
            dtgvSinhVien.Columns["Email"].Width = 150;
            dtgvSinhVien.Columns["MaLop"].Width = 50;




            // hiển thị cb khoa
            String querry_Khoa = "select * From Khoa";
            cbKhoa.DataSource = DataProvider.instanse.Executequerry(querry_Khoa);
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            cb_lop.DataSource = LopDAO.LoadDSLop();
            cb_lop.DisplayMember = "TenLop";
            cb_lop.ValueMember = "MaLop";
            lb_ThongBao.Hide();
            lb_MSVcheck.Hide();
            lb_SDTcheck.Hide();
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbKhoa.SelectedValue != null && !(cbKhoa.SelectedValue is DataRowView))
            {

            }
        }
        public void Macdinh()
        {
            tx_Name.Enabled = false; tx_Name.Text = "";
            tx_Email.Enabled = false; tx_Email.Text = "";
            tx_MSV.Enabled = false; tx_MSV.Text = "";
            tx_SĐT.Enabled = false; tx_SĐT.Text = "";
            bt_Edit.Enabled = false;
            bt_Save.Enabled = false;
            bt_huy.Enabled = false;
            bt_ADD.Enabled = true;
            bt_delete.Enabled = false;
            bt_Exit.Enabled = true;
            rdb_Nam.Checked = false;
            rdb_Nu.Checked = false;
            cb_lop.Enabled = false; cb_lop.Text = "";
        }
        public void TrangThaiKhiCoSK()
        {
            cb_lop.Enabled = true;
            tx_Name.Enabled = true;
            tx_Email.Enabled = true;
            tx_MSV.Enabled = true;
            tx_SĐT.Enabled = true;
            bt_Edit.Enabled = false;
            bt_Save.Enabled = true;
            bt_huy.Enabled = true;
            bt_ADD.Enabled = false;
            bt_delete.Enabled = false;
            bt_Exit.Enabled = false;
        }



        private void bt_ADD_Click(object sender, EventArgs e)
        {
            TrangThaiKhiCoSK();
            tx_Name.Text = "";
            tx_Email.Text = "";
            tx_MSV.Text = "";
            tx_SĐT.Text = "";
            trangthai = 0;// trạng thái của thêm mới

        }

        private void dtgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tx_Name.Text = dtgvSinhVien.CurrentRow.Cells["HoVaTen"].Value.ToString();
                tx_Email.Text = dtgvSinhVien.CurrentRow.Cells["Email"].Value.ToString();
                tx_MSV.Text = dtgvSinhVien.CurrentRow.Cells["MaSV"].Value.ToString();
                tx_SĐT.Text = Convert.ToString(dtgvSinhVien.CurrentRow.Cells["SDT"].Value);
                if (dtgvSinhVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") rdb_Nam.Checked = true;
                else rdb_Nu.Checked = true;
                cb_lop.Text = LopDAO.LoadTenLop((int)dtgvSinhVien.CurrentRow.Cells["MaLop"].Value);
                dtp_NgaySinh.Text = dtgvSinhVien.CurrentRow.Cells["NgaySinh"].Value.ToString();

                if (bt_Edit.Enabled == false) bt_Edit.Enabled = true;
                if (bt_delete.Enabled == false) bt_delete.Enabled = true;
            }
        }

        public bool checkDuLieu()
        {
            if (tx_Name.Text == "")
            {
                lb_ThongBao.Text = "Bạn chưa nhập họ và tên ";
                lb_ThongBao.Show();
                return false;
            }
            else if (tx_Email.Text == "")
            {
                lb_ThongBao.Text = "Bạn chưa nhâp email của sinh viên";
                lb_ThongBao.Show();

                return false;
            }

            else if (tx_SĐT.Text == "")
            {
                lb_ThongBao.Text = "Bạn chưa nhâp SĐT của sinh viên";
                lb_ThongBao.Show(); return false;
            }

            else if (tx_MSV.Text == "")
            {
                lb_ThongBao.Text = "Bạn chưa nhâp MSV của sinh viên";
                lb_ThongBao.Show(); return false;
            }

            //else if (cb_lop.Select == null)
            //{
            //    MessageBox.Show("Bạn chưa chọn lớp cho sính viên đó", "Thông báo"); return false;
            //}
            else if (rdb_Nu.Checked == false && rdb_Nam.Checked == false)

            {
                lb_ThongBao.Text = "Bạn chưa chọn  giới tính của sinh viên";
                lb_ThongBao.Show(); return false;
            }



            return true;
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (trangthai == 0)
            {
                if (checkDuLieu())
                {
                    try
                    {
                        string ngaySV = dtp_NgaySinh.Value.ToString("MM/dd/yyyy");
                        string GT = "";
                        if (rdb_Nam.Checked == true) GT = rdb_Nam.Text.ToString();
                        else if (rdb_Nu.Checked == true) GT = rdb_Nu.Text.ToString();
                        SinhVienDAO.AddSV(tx_MSV.Text, tx_Name.Text, GT, ngaySV, int.Parse(tx_SĐT.Text), tx_Email.Text, int.Parse(cb_lop.SelectedValue.ToString().Trim()));
                        MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo");
                        Macdinh();
                        LoadForm();
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu nhập vào đã sai định dạng . Vui lòng kiểm tra lại dữ liệu nhập vào");
                    }

                }
            }
            else if (trangthai == 1)
            {
                if (checkDuLieu())
                {
                    try
                    {
                        string ngaySV = dtp_NgaySinh.Value.ToString("MM/dd/yyyy");
                        string GT = "";
                        if (rdb_Nam.Checked == true) GT = rdb_Nam.Text.ToString();
                        else if (rdb_Nu.Checked == true) GT = rdb_Nu.Text.ToString();
                        string TenLop = cb_lop.ValueMember;
                        if (TenLop != cb_lop.Text)
                        {
                            SinhVienDAO.EditSV(tx_MSV.Text, tx_Name.Text, GT, ngaySV, int.Parse(tx_SĐT.Text), tx_Email.Text, int.Parse(cb_lop.SelectedValue.ToString().Trim()));
                        }
                        else
                        {
                            SinhVienDAO.EditSV1(tx_MSV.Text, tx_Name.Text, GT, ngaySV, int.Parse(tx_SĐT.Text), tx_Email.Text);

                        }
                        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                        Macdinh();
                        LoadForm();
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu nhập vào đã sai định dạng . Vui lòng kiểm tra lại dữ liệu nhập vào");
                    }

                }
            }
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            TrangThaiKhiCoSK();
            tx_MSV.Enabled = false;
            trangthai = 1;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string Masv = null;
            Masv = dtgvSinhVien.CurrentRow.Cells["MaSV"].Value.ToString();
            if (Masv != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa sinh viên này ra khỏi dách sách không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SinhVienDAO.DeleteSV(Masv);
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                    Macdinh();
                    LoadForm();
                }

            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thao tác thêm không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Macdinh();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<SinhVien> ListSV = SinhVienDAO.LoadDSSinhVien_TheoKhoa(int.Parse(cbKhoa.SelectedValue.ToString()));
            if (ListSV != null)
            {
                dtgvSinhVien.DataSource = ListSV;
                dtgvSinhVien.DataSource = ListSV;

                dtgvSinhVien.Columns["HoVaTen"].HeaderText = "Họ và Tên";
                dtgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dtgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dtgvSinhVien.Columns["SDT"].HeaderText = "Số điện thoại";
                dtgvSinhVien.Columns["MaLop"].HeaderText = "Mã Lớp";
                dtgvSinhVien.Columns["HoVaTen"].Width = 150;
                dtgvSinhVien.Columns["NgaySinh"].Width = 100;
                dtgvSinhVien.Columns["GioiTinh"].Width = 100;
                dtgvSinhVien.Columns["SDT"].Width = 100;
                dtgvSinhVien.Columns["Email"].Width = 150;
                dtgvSinhVien.Columns["MaLop"].Width = 50;




                // hiển thị cb khoa
                String querry_Khoa = "select * From Khoa";
                cbKhoa.DataSource = DataProvider.instanse.Executequerry(querry_Khoa);
                cbKhoa.DisplayMember = "TenKhoa";
                cbKhoa.ValueMember = "MaKhoa";
                cb_lop.DataSource = LopDAO.LoadDSLop();
                cb_lop.DisplayMember = "TenLop";
                cb_lop.ValueMember = "MaLop";
                lb_ThongBao.Hide();
            }
            else
            {
                MessageBox.Show("Khoa bạn chọn không có sinh viên nào ", "THông báo");
            }

        }

        private void button9_Click(object sender, EventArgs e)// button làm mới danh sách
        {
            LoadForm();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            List<SinhVien> ListSV = SinhVienDAO.TimKiem(txb_ChuoiTK.Text);
            if (ListSV != null)
            {
                dtgvSinhVien.DataSource = ListSV;
                dtgvSinhVien.DataSource = ListSV;

                dtgvSinhVien.Columns["HoVaTen"].HeaderText = "Họ và Tên";
                dtgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dtgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dtgvSinhVien.Columns["SDT"].HeaderText = "Số điện thoại";
                dtgvSinhVien.Columns["MaLop"].HeaderText = "Mã Lớp";
                dtgvSinhVien.Columns["HoVaTen"].Width = 150;
                dtgvSinhVien.Columns["NgaySinh"].Width = 100;
                dtgvSinhVien.Columns["GioiTinh"].Width = 100;
                dtgvSinhVien.Columns["SDT"].Width = 100;
                dtgvSinhVien.Columns["Email"].Width = 150;
                dtgvSinhVien.Columns["MaLop"].Width = 50;




                // hiển thị cb khoa
                String querry_Khoa = "select * From Khoa";
                cbKhoa.DataSource = DataProvider.instanse.Executequerry(querry_Khoa);
                cbKhoa.DisplayMember = "TenKhoa";
                cbKhoa.ValueMember = "MaKhoa";
                cb_lop.DataSource = LopDAO.LoadDSLop();
                cb_lop.DisplayMember = "TenLop";
                cb_lop.ValueMember = "MaLop";
                lb_MSVcheck.Hide();
                lb_SDTcheck.Hide();
            }
            else
            {
                MessageBox.Show("Khoa bạn chọn không có sinh viên nào ", "THông báo");
            }
        }

        private void lop_Click(object sender, EventArgs e)
        {

        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
