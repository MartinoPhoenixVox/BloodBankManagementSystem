using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_BBMS;
using BUS_BBMS;
namespace GUI_BBMS
{
    public partial class Form1 : Form
    {
        BUS_NguoiHienMau busNHM = new BUS_NguoiHienMau();
        public Form1()
        {
            InitializeComponent();
        }

        private void btExit_nhm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btAdd_nhm_Click(object sender, EventArgs e)
        {
            if (txt_nhmHoTen.Text != "" && txt_nhmSDT.Text != "" && txt_nhmEmail.Text != "" && txt_nhmDiaChi.Text != "" && (rd_nhmGioiTinhNam.Checked || rd_nhmGioiTinhNu.Checked) && dtp_nhmNgaySinh.Checked)
            {
                int gioiTinh;
                if (rd_nhmGioiTinhNam.Checked)
                {
                    gioiTinh = 1;
                }
                else
                {
                    gioiTinh = 0;
                }
                DTO_NguoiHienMau dto_nhm = new DTO_NguoiHienMau(0, txt_nhmHoTen.Text, dtp_nhmNgaySinh.Value, txt_nhmDiaChi.Text, gioiTinh, txt_nhmSDT.Text, txt_nhmEmail.Text);
                if (busNHM.addNHM(dto_nhm))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgv_nhm.DataSource = busNHM.getNHM();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_nhm.DataSource = busNHM.getNHM();
        }
        private void btMod_nhm_Click(object sender, EventArgs e)
        {
            if (dgv_nhm.SelectedRows.Count > 0)
            {
                if (txt_nhmHoTen.Text != "" && txt_nhmSDT.Text != "" && txt_nhmEmail.Text != "" && txt_nhmDiaChi.Text != "" && (rd_nhmGioiTinhNam.Checked || rd_nhmGioiTinhNu.Checked) && dtp_nhmNgaySinh.Checked)
                {
                    DataGridViewRow row = dgv_nhm.SelectedRows[0];
                    int MaNHM = Convert.ToInt16(row.Cells[0].Value.ToString());
                    int gioiTinh;
                    if (rd_nhmGioiTinhNam.Checked)
                    {
                        gioiTinh = 1;
                    }
                    else
                    {
                        gioiTinh = 0;
                    }
                    DTO_NguoiHienMau dto_nhm = new DTO_NguoiHienMau(MaNHM, txt_nhmHoTen.Text, dtp_nhmNgaySinh.Value, txt_nhmDiaChi.Text, gioiTinh, txt_nhmSDT.Text, txt_nhmEmail.Text);
                    if (busNHM.modNHM(dto_nhm))
                    {
                        MessageBox.Show("Sửa thành công!");
                        dgv_nhm.DataSource = busNHM.getNHM();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa!");
            }
        }

        private void btDel_nhm_Click(object sender, EventArgs e)
        {
            if (dgv_nhm.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_nhm.SelectedRows[0];
                int MaNHM = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (busNHM.delNHM(MaNHM))
                {
                    MessageBox.Show("Xóa thành công!");
                    dgv_nhm.DataSource = busNHM.getNHM();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa!");
            }
        }

        private void dgv_nhm_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv_nhm.SelectedRows[0];
                txt_nhmHoTen.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                txt_nhmDiaChi.Text = row.Cells[4].Value.ToString();
                txt_nhmSDT.Text = row.Cells[6].Value.ToString();
                txt_nhmEmail.Text = row.Cells[7].Value.ToString();
                if (Int32.Parse(row.Cells[5].Value.ToString()) == 1)
                {
                    rd_nhmGioiTinhNam.Checked = true;
                    rd_nhmGioiTinhNu.Checked = false;
                }
                else
                    if (Int32.Parse(row.Cells[5].Value.ToString()) == 0)
                {
                    rd_nhmGioiTinhNu.Checked = true;
                    rd_nhmGioiTinhNam.Checked = false;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
