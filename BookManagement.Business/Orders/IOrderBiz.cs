﻿using BookManagement.Models;

namespace BookManagement.Business
{
    public interface IOrderBiz
    {
        bool CreateNewOrder(Order order);
        Order GetOrderById(Guid id);
    }
}