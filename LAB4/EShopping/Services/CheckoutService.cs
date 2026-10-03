using EShopping.Adapters;
using EShopping.Data;
using EShopping.Entities;

namespace EShopping.Services
{
    public class CheckoutService
    {
        private readonly PaymentAdapter paymentAdapter = new PaymentAdapter();
        private readonly EmailAdapter emailAdapter = new EmailAdapter();
        private readonly OrderRepository orderRepository = new OrderRepository();

        public bool ThanhToan(Order order, string cardType, string cardNumber, string email)
        {
            string reference;
            if (!paymentAdapter.Pay(cardType, cardNumber, order.TongTien, out reference))
                return false;

            order.TrangThai = "Đã thanh toán";
            orderRepository.Save(order);

            if (!string.IsNullOrWhiteSpace(email))
                emailAdapter.Send(email, "Xác nhận đơn hàng", "Đơn hàng đã được thanh toán thành công.");

            return true;
        }
    }
}
