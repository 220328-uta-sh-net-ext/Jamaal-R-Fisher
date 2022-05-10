using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class Admin : User
{
    public string Adminname { get; set; }
    public string Adminpassword { get; set; }

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
        Adminname = "Jamaal";
        Adminpassword = "adminJamaal";

        /*
        _reviews = new List<Review>()
        {
            new Review()
        };
        */
    }
    public override string ToString()
    {
        string result = $"Admin Name: {Adminname}\nPassword: \n";
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