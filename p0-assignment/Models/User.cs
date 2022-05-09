using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class User
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Zipcode { get; set; }

    List<Review> _reviews;
    /*
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
    public User()
    {
        Id = "";
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

        string result = $"User Name: {Username}\nPassword: \nZip Code: {Zipcode}";
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