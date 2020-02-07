using OnlineBabyshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Data.Interfaces
{
    public interface IOrdersRepository
    {
        void CreateOrder(Order order);
        void CreateOrderDetails(OrderDetails orderDetails);
    }
}
