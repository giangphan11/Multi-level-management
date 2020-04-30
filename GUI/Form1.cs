using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class Form1 : Form
    {
        KhachHangBLL khachHangBLL= null;
        List<KhachHang> dsKH = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void hienThi()
        {
            khachHangBLL = new KhachHangBLL();
            dsKH = khachHangBLL.dsKH();
            
            txtSLKH.Text = dsKH.Count + "";
            int row = 0;
            gvKhachHang.Rows.Clear();
            cboThanhPho.Items.Clear();
            thanhPhoCbo.Items.Clear();
            HashSet<string> dsTp = new HashSet<string>();
            foreach (KhachHang kh in dsKH)
            {
                dsTp.Add(kh.thanhP);
                gvKhachHang.Rows.Add();
                gvKhachHang.Rows[row].Cells[0].Value = kh.ma;
                gvKhachHang.Rows[row].Cells[1].Value = kh.tenCty;
                gvKhachHang.Rows[row].Cells[2].Value = kh.diaChi;
                gvKhachHang.Rows[row].Cells[3].Value = kh.thanhP;
                gvKhachHang.Rows[row].Cells[4].Value = kh.phone;
                row++;
            }
            
            foreach(string s in dsTp)
            {
                cboThanhPho.Items.Add(s);
                thanhPhoCbo.Items.Add(s);
            }
            
            cboThanhPho.Text = cboThanhPho.Items[0].ToString();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string tpselectd = (string)cboThanhPho.SelectedItem;
            gvKhachHang.Rows.Clear();
            int row = 0;
            
            foreach (KhachHang kh in dsKH)
            {
                if(kh.thanhP.Equals(tpselectd))
                {
                    gvKhachHang.Rows.Add();
                    gvKhachHang.Rows[row].Cells[0].Value = kh.ma;
                    gvKhachHang.Rows[row].Cells[1].Value = kh.tenCty;
                    gvKhachHang.Rows[row].Cells[2].Value = kh.diaChi;
                    gvKhachHang.Rows[row].Cells[3].Value = kh.thanhP;
                    gvKhachHang.Rows[row].Cells[4].Value = kh.phone;
                    row++;
                }
            }
            txtSLKH.Text = row + "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            hienThi();
        }
    }
}
