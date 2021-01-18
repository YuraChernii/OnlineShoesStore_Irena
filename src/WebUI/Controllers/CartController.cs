using CleanArchitecture.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class CartController
    {
        private ApplicationDbContext applicationDbContext;
        //private IOrderProcessor orderProcessor;

        public CartController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        //public ViewResult Index(Cart cart, string returnUrl)
        //{
        //    return View(new CartIndexViewModel
        //    {
        //        Cart = cart,
        //        ReturnUrl = returnUrl
        //    });
        //}

        //public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl)
        //{
        //    Product product = repository.Products
        //        .FirstOrDefault(p => p.ProductId == productId);

        //    if (product != null)
        //    {
        //        cart.AddItem(product, 1);
        //    }
        //    return RedirectToAction("Index", new { returnUrl });
        //}

        //public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl)
        //{
        //    Product product = repository.Products
        //        .FirstOrDefault(p => p.ProductId == productId);

        //    if (product != null)
        //    {
        //        cart.RemoveLine(product);
        //    }
        //    return RedirectToAction("Index", new { returnUrl });
        //}

        //public PartialViewResult Summary(Cart cart)
        //{
        //    return PartialView(cart);
        //}

        //public ViewResult Checkout()
        //{
        //    return View(new ShippingDetails());
        //}

        //[HttpPost]
        //public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        //{
        //    if (cart.Lines.Count() == 0)
        //    {
        //        ModelState.AddModelError("", "Sorry, your cart is empty!");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        orderProcessor.ProcessOrder(cart, shippingDetails);
        //        cart.Clear();
        //        return View("Completed");
        //    }
        //    else
        //    {
        //        return View(shippingDetails);
        //    }
        //}

        //private Cart GetCart()
        //{

        //    Cart cart = (Cart)Session["Cart"];
        //    if (cart == null)
        //    {
        //        cart = new Cart();
        //        Session["Cart"] = cart;
        //    }
        //    return cart;
        //}
    }
}
