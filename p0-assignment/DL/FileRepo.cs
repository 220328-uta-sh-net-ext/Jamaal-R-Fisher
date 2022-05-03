using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DL;

public class FileRepo : IRepo
{
    /*
    public FileRepo()
    {
    
    }
    */

    readonly string filePath = "../DL/Restaurants.json";
    string? jsonString;

    public Restaurant AddRestaurant(Restaurant restaurantToAdd)
    {
        List<Restaurant>? restaurants = GetAllRestaurants();
        restaurants.Add(restaurantToAdd);
        string? restaurantString = JsonSerializer.Serialize<List<Restaurant>>(restaurants, new JsonSerializerOptions { WriteIndented = true });
        try
        {
            File.WriteAllText(filePath + "Restaurant.json", restaurantString);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Please check the path, " + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Please check the file name, " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return restaurantToAdd;
    }
    public List<Restaurant> GetAllRestaurants()
    {
        try
        {
            jsonString = File.ReadAllText(filePath + "Restaurant.json");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Please check the path, " + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Please check the file name, " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        if (!string.IsNullOrEmpty(jsonString))
            return JsonSerializer.Deserialize<List<Restaurant>>(jsonString)!;
        throw new InvalidDataException("json data missing or invalid");
    }
    public void AddReview(int restaurantId, Review reviewToAdd)
    {
        throw new NotImplementedException();
    }

    public List<Restaurant> SearchRestaurants(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public bool IsDuplicate(Restaurant restaurant)
    {
        throw new NotImplementedException();
    }
}
