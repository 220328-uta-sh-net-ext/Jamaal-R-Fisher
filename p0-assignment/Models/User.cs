using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CevicheModels;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Zipcode { get; set; }
    public string UserReview { get; set; }

    /*
    List<Review> _review;

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
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public User()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        UserId = 0;
        Username = "";
        Password = "";
        Zipcode = "";

        /*
        _reviews = new List<Review>()
        {
            new Review()
        };
        */
    }
    public override string ToString()
    {

        string result = $"UserId: {UserId}\nUserName: {Username}\nPassword: \nZipCode: {Zipcode}";
        {
            return result;
        }
    /*
        if (Reviews is not null && Reviews.Count > 0)
        {
            result += "\nReviews: " + string.Join(", ", Reviews.Select(a => a.Username));
        }
    */
        
    }
}