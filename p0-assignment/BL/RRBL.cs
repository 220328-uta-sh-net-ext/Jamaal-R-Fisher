﻿using CevicheModels;
using CevicheDL;

namespace CevicheBL;
public class RRBL : IBL
{
    readonly IRepo _dl;

    public RRBL(IRepo repo)
    {
        this._dl = repo;
    }

    /// <summary>
    /// Gets all restaurants
    /// </summary>
    /// <returns>list of all restaurants</returns>

    public List<Restaurant> GetAllRestaurants()
    {
        throw new NotImplementedException();
    }

    /*
    /// <summary>
    /// Adds a new restaurant to the list
    /// This method will check for the duplicate record before persisting
    /// </summary>
    /// <param name="restaurantToAdd">restaurant object to add</param>
    /// <exception cref="DuplicateRecordException">When there is a restaurant that already exists</exception>
    /// 
    */

    public void AddNewRestaurant(Restaurant newlyaddedRestaurant)
    {
        throw new NotImplementedException();
    }

    /*
    /// <summary>
    /// Adds a new review to the restaurant that exists on that index
    /// </summary>
    /// <param name="restaurantId">index of the restaurant to leave a review for</param>
    /// <param name="reviewToAdd">a review object to be added to the restaurant</param>
    ///
    */

    public void AddReview(int restaurantId, Review reviewToAdd)
    {
        throw new NotImplementedException();
    }

    public List<Restaurant> SearchRestaurants(string searchString)
    {
        List<Restaurant>? restaurants = _dl.GetAllRestaurants();                                    //Query Syntax

        var filteredRestaurants = restaurants.Where(x => x.Name.Contains(searchString)).ToList();     // Method Syntax

        return filteredRestaurants;
    }

    Restaurant IBL.AddNewRestaurant(Restaurant newlyaddedRestaurant)
    {
        throw new NotImplementedException();
    }

    public User AddNewUser(User newUser)
    {
        throw new NotImplementedException();
    }
}
