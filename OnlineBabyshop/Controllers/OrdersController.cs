using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBabyshop.Data;
using OnlineBabyshop.Data.Interfaces;
using OnlineBabyshop.Models;

namespace OnlineBabyshop.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly ApplicationDbContext _context;
      
        public OrdersController(IOrdersRepository ordersRepository, ShoppingCart shoppingCart, ApplicationDbContext context)
        {
            _ordersRepository = ordersRepository;
            _shoppingCart = shoppingCart;
            _context = context;
        }


        public IActionResult Checkout()
        {
            return View();
        }

        

        public IActionResult CheckoutOne()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Checkout(Order order)
        {
            OrderDetails orderDetails = new OrderDetails();
           
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some drinks first");
            }

            if (ModelState.IsValid)
            {
                orderDetails.ShoppingCartItems = items;
               _ordersRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }


        //[HttpPost]
        //public IActionResult CheckoutOne(OrderDetails orderDetails)
        //{
        //    var items = _shoppingCart.GetShoppingCartItems();
        //    _shoppingCart.ShoppingCartItems = items;
        //    if (_shoppingCart.ShoppingCartItems.Count == 0)
        //    {
        //        ModelState.AddModelError("", "Your card is empty, add some drinks first");
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _ordersRepository.CreateOrderDetails(orderDetails);
        //        _shoppingCart.ClearCart();
        //        return RedirectToAction("CheckoutComplete");
        //    }

        //    return View(orderDetails);
        //}

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
            ViewBag.OrderDetails = _context.OrderDetails.LastOrDefaultAsync();

            return View();
        }



        //public ViewResult CheckoutComplete()
        //{
        //    var items = _shoppingCart.GetShoppingCartItems();
        //    _shoppingCart.ShoppingCartItems = items;

        //    var orderViewModel = new OrderViewModel
        //    {
        //        ShoppingCart = _shoppingCart,


        //    };
        //    return View(orderViewModel);
        //}


        //[HttpPost]
        //public IActionResult CheckoutComplete (OrderDetails orderDetails)
        //{


        //    return View("CheckoutComplete", orderDetails.OrderId);
        //}






    }
}