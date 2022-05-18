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

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.ID = restaurants.Max(r => r.ID)+1;
        }

        public Restaurant Get(int Id)
        {
            return restaurants.FirstOrDefault(r => r.ID==Id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(x => x.ID);
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.ID);
            if (existing!=null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }
    }
}
