using Models;

namespace BL;

public interface IBL
{
    Restaurant AddRestaurant(Restaurant restaurantToAdd);
    List<Restaurant> GetAllRestaurants();
    List<Restaurant> GetName(string Name);
    List<Restaurant> GetZipcode(string Zipcode);
    List<Restaurant> GetRating(double Rating);
    List<Restaurant> GetReview(string Review);
    List<Restaurant> GetTotalRatings(int TotalRatings);

    void AddReview(int restaurantId, Review reviewToAdd);
    void AddNewUser(User newUser);
}

interface IRestaurantSearch
{
    List<Restaurant> SearchRestaurants(string searchString);

    // List<Restaurant> SearchAll();
}