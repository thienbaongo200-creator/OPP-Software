using System;
using System.Windows.Forms;
using EShopping.Entities;
using EShopping.Services;

namespace EShopping.Forms
{
    public partial class FrmCheckout : Form
    {
        private readonly CheckoutService checkoutService = new CheckoutService();

        public FrmCheckout()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Vui lòng nhập tổng tiền hợp lệ.");
                return;
            }

            Order order = new Order
            {
                NgayDat = DateTime.Now,
                NguoiNhan = txtRecipient.Text,
                DiaChiNhan = txtAddress.Text,
                DienThoaiNhan = txtPhone.Text,
                TongTien = amount,
                TienHang = amount,
                PhiGiaoHang = 0,
                EmailXacNhan = txtEmail.Text
            };

            if (checkoutService.ThanhToan(order, cboCardType.Text, txtCardNumber.Text, txtEmail.Text))
                MessageBox.Show("Thanh toán thành công.");
            else
                MessageBox.Show("Thanh toán thất bại.");
        }
    }
}
