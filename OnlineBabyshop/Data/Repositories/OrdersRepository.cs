using OnlineBabyshop.Data.Interfaces;
using OnlineBabyshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Data.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;


        public OrdersRepository(ApplicationDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
          


            _appDbContext.Order.Add(order);
       

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            _appDbContext.SaveChanges();


            foreach (ShoppingCartItems shoppingCartItem in shoppingCartItems)
            {
                var orderDetails = new OrderDetails()
                {
                    ShoppingCartItemsId = shoppingCartItem.ShoppingCartItemsId,
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Product.Price,
                    OrderTotal = order.OrderTotal
                  
                };

                CreateOrderDetails(orderDetails);
            }

            
        }


        public void CreateOrderDetails(OrderDetails orderDetails)
        {
            //order.OrderPlaced = DateTime.Now;
            var order = _appDbContext.Order.ToList();
            int orderId = 0;
            foreach (var item in order)
            {
                orderId = item.OrderId;
            }
            //int orderId = order.LastOrDefault().OrderId;

            orderDetails.OrderId = orderId;
            _appDbContext.OrderDetails.Add(orderDetails);

            //var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            //foreach (var shoppingCartItem in shoppingCartItems)
            //{
            //    var Details = new OrderDetails()
            //    {
            //        Amount = shoppingCartItem.Amount,
            //        ProductId = shoppingCartItem.Product.ProductId,
            //        OrderId= orderDetails.OrderId,
            //        ShoppingCartItemsId = shoppingCartItem.ShoppingCartItemsId,
            //        Price = shoppingCartItem.Product.Price
            //    };

            //    _appDbContext.OrderDetails.Add(Details);
            //}

            _appDbContext.SaveChanges();
        }









    }
}
