﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Order
    {
        public List<Dish> Dishes { get; set; }
        public double TotalPrice { get; set; }

        public Order()
        {
            Dishes = new List<Dish>();
            TotalPrice = 0;
        }

        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
            TotalPrice += dish.Price;
        }
        

        public void RemoveDish(Dish dish)
        {
            Dishes.Remove(dish);
            TotalPrice -= dish.Price;
        }

    }
}
