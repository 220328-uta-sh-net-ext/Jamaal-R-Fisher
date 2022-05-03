using Models;

namespace BL;

public interface IBL
{
    Restaurant AddRestaurant(Restaurant restaurantToAdd);

    List<Restaurant> SearchRestaurants(string searchString);

    List<Restaurant> GetAllRestaurants();

    void AddReview(int restaurantId, Review reviewToAdd);
    void AddNewUser(User newUser);
}

interface IRestaurantSearch
{
    List<Restaurant> SearchAll();
}