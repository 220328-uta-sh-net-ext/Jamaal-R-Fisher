using CustomExceptions;
using System.Text.RegularExpressions;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CevicheModels;

public class Admin
{
    public int AdminId { get; set; }
    public string AdminName { get; set; }
    public string AdminPassword { get; set; }
    public int TotalUsers { get; set; }
    public int TotalRestaurants { get; set; }

    /*
    List<Review> _reviews;
    public List<Review> Reviews
    {
        get => _reviews;

        //cannot set more than 2 reviews per restaurant
        set
        {
            if (value.Count <= 2)
                _reviews = value;
            else
                throw new Exception("User cannot give more than 2 reviews per restaurant");
        }
    }
    */

    //Default constructor to add default values to the properties
    public Admin()
    {
        AdminId = 0;
        AdminName = "Jamaal";
        AdminPassword = "adminJamaal";
        TotalUsers = 0;
        TotalRestaurants = 0;

        /*
        _reviews = new List<Review>()
        {
            new Review()
        };
        */
    }
    public override string ToString()
    {
        string result = $"Admin Name: {AdminName}\nPassword: \n";
        {
            return result;
        }

        /*
        if (Reviews is not null && Reviews.Count > 0)
        {
            result += "\nReview: " + string.Join(", ", Reviews.Select(a => a.Username));
        }
        */
    }
}