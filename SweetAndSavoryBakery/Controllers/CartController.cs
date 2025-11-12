using SweetAndSavoryBakery.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SweetAndSavoryBakery.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private const string CartKey = "CART";

        // Lấy giỏ hàng trong session
        private List<CartItem> GetCart()
        {
            if (Session[CartKey] == null)
                Session[CartKey] = new List<CartItem>();
            return (List<CartItem>)Session[CartKey];
        }

        // Thêm sản phẩm
        public ActionResult Add(int id, int quantity = 1)
        {
            // Cần đảm bảo quantity tối thiểu là 1 nếu người dùng không nhập
            if (quantity < 1) quantity = 1;

            var product = db.Products.Find(id);
            if (product == null) return HttpNotFound();

            var cart = GetCart();
            var existing = cart.FirstOrDefault(c => c.ProductId == id);

            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    Quantity = quantity // LƯU SỐ LƯỢNG MỚI NHẬP
                });
            }

            // TODO: Nên thêm logic kiểm tra tổng số lượng không vượt quá product.Stock

            return RedirectToAction("Index");
        }

        private const decimal FREESHIP_THRESHOLD = 200000; // Ngưỡng freeship 200.000 VNĐ
        private const decimal SHIPPING_FEE = 30000;       // Phí ship mặc định 30.000 VNĐ

        // Hiển thị giỏ hàng
        public ActionResult Index()
        {
            var cart = GetCart();
            decimal subTotal = cart.Sum(x => x.Quantity * x.Price);

            // Tính phí vận chuyển và tổng cuối cùng
            decimal shippingFee = (subTotal >= FREESHIP_THRESHOLD) ? 0 : SHIPPING_FEE;
            decimal finalTotal = subTotal + shippingFee;

            // Truyền dữ liệu cần thiết sang View
            ViewBag.SubTotal = subTotal;
            ViewBag.ShippingFee = shippingFee;
            ViewBag.FinalTotal = finalTotal;
            ViewBag.IsFreeShip = (shippingFee == 0);
            ViewBag.FREESHIP_THRESHOLD = FREESHIP_THRESHOLD;
            return View(cart);
        }

        // Xóa sản phẩm
        public ActionResult Remove(int id)
        {
            var cart = GetCart();
            var item = cart.FirstOrDefault(x => x.ProductId == id);
            if (item != null) cart.Remove(item);
            return RedirectToAction("Index");
        }

        // Thanh toán
        public ActionResult Checkout()
        {
            Index();
            return View();
        }
    }
}
