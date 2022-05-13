using CevicheModels;
using System.Collections.Generic;

namespace CevicheDL;


public interface IRepo
{
    Restaurant AddRestaurant(Restaurant restaurantToAdd);

    List<Restaurant> GetAllRestaurants();

    void AddReview(int restaurantId, Review reviewToAdd);

    List<Restaurant> SearchRestaurants(string searchTerm);

    bool IsDuplicate(Restaurant restaurant);
    List<Review> GetAllReviews();
}
