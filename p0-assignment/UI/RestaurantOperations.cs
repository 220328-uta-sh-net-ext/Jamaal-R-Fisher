using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Models;
using Serilog;
using UI;

namespace UI;

class RestaurantOperations
{
    readonly IRepo repository;

    public RestaurantOperations(IRepo repository)
    {
        this.repository = repository;
    }

    public void GetAllRestaurants()
    {
        List<Restaurant>? restaurants = repository.GetAllRestaurants();
        foreach (Restaurant? restaurantToAdd in restaurants)
        {
            Console.WriteLine(restaurantToAdd);
            Console.WriteLine("=======================");
        }
    }

    /// <summary>
    /// only for testing purpose to check if restaurant was added
    /// </summary>
    /// 
    /*
    public void AddSampleRestaurant()
    {
        var restaurant = new Restaurant()
        {
            Id = 0,
            Name = "Kabuto Japanese Steakhouse & Sushi Bar",
            Zipcode = "27407",
            Review = new List<Review>() {
                new Review()
                {
                    Rating = 5.5,
                    Review = "Fresh tuna, great atmosphere, but sometimes long wait times.",
                }
            }
            TotalRatings = 1;
        }

        // repository.AddRestaurant(restaurant);
    }
    */
}

