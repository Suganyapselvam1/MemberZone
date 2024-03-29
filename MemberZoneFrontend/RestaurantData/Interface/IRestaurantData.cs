﻿using RestaurantData.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;/// <summary>
/// //
/// </summary>

namespace RestaurantData.Interface
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int Id);
        void Add(Restaurant restaurant);
        void Update(Restaurant restaurant);
    }
}
