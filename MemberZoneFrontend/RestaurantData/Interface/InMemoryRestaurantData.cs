using RestaurantData.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantData.Interface
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant{ID=1,Name="Apple Restaurant",Cuisine=CuisineType.Italian },
                new Restaurant{ID=2,Name="Mango Restaurant",Cuisine=CuisineType.Italian  },
                new Restaurant{ID=3,Name="A2B Restaurant",Cuisine=CuisineType.Italian },
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(x => x.ID);
        }
    }
}
