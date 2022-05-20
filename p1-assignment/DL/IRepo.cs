using CevicheModels;
using System.Collections.Generic;

namespace CevicheDL;


public interface IRepo
{
    Restaurant AddRestaurant(Restaurant newlyaddedRestaurant);

    List<Restaurant> GetAllRestaurants();

    void AddReview(int restaurantId, Review reviewToAdd);

    List<Review> GetAllReviews();

    User AddNewUser(User newlyaddedUser);

    List<User>? GetAllUsers();

    List<Restaurant> SearchRestaurants(string searchColumn);

    bool IsDuplicate(Restaurant restaurant);
}
