using CustomExceptions;
using System.Text.RegularExpressions;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CevicheModels;

public class Restaurant
{
    //In a restaurant, I want to store name, city, state of a restaurant

    //This is property, a type member
    //Access modifier controls the visibility of type and type members.
    //There are four access modifiers: Public, Private, Internal, Protected
    //public is the most visible, private is the least visible
    //By default, class member has private access modifier
    //Class, by default, are internal unless you explicitly say otherwise
    public int Id { get; set; }
    public string Name { get; set; }
    public string Zipcode { get; set; }
    public double Rating { get; set; }
    public string UserReview { get; set; }
    public int TotalRatings { get; set; }

    
    public Restaurant()
    {
        Id = 0;
        Name = "";
        Zipcode = "";
        Rating = 0;
        UserReview = "";
        TotalRatings = 0;
    }
    public override string ToString()
    {
        return $"Id: {Id}\nName: {Name}\nZipCode: {Zipcode}\nRating: {Rating}\nUserReview: {UserReview}\nTotalRatings: {TotalRatings}";
    }


    /*
    public Restaurant(string name)
    {
        this.Reviews = new List<Review>();
        this._name = name;
    }
    
    /// <summary>
    /// Converting Restaurant table's data row into Restaurant Object
    /// </summary>
    /// <param name="row">a data row from Restaurant object, must have id, name, city, state columns</param>
    */
    /*
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Restaurant(DataRow row)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        this.Id = (int) row["Id"];
        this.Name = row["Name"].ToString() ?? "";
        this.Zipcode = row["Zip Code"].ToString() ?? "";
        this.Rating = (double)row["Rating"];
        this.Review = row["Review"].ToString() ?? "";
        this.TotalRatings = (int)row["Total Ratings"];
    }
    */

    // private string _name;

    /*
    public string Name
    {
        get => _name;
        set
        {
            Regex pattern = new Regex("^[a-zA-Z0-9 !?']+$");
            if(string.IsNullOrWhiteSpace(value))
            {
                //we're checking whether this string is null or whitespace
                throw new InputInvalidException("Name can't be empty");
            }
            //even if the string is not null or white space,
            //we can still check for the name's validity by using RegEx (Regular Expression)
            //Regular Expression is a way to pattern match a string for a certain condition
            //it has a confusing syntax, so I recommend looking up language specific RegEx reference page to build one
            
            else if(!pattern.IsMatch(value))
            {
                throw new InputInvalidException("Restaurant name can only have alphanumeric characters, white space, !, ?, and '.");
            }
            else
            {
                this._name = value;
            }
        } 
    }

    


    // //our own custom getter and setter for the private backing field
    // public string GetName() {
    //     return this._name;
    // }
    // public void SetName(string name)
    // {
    //     //input validation
    //     if(name == "")
    //     {
    //         Console.WriteLine("Name Cannot Be Empty");
    //     }
    //     this._name = name;
    // }

    // private string _city;

    public List<Review> Reviews { get; set; }

    */


    /*
    /// <summary>
    /// Takes in Restaurant Table's DataRow and fills the columns with the Restaurant Instance's info
    /// </summary>
    /// <param name="row">Restaurant Table's DataRow pass by ref</param>
    /// 
    
    public void ToDataRow(ref DataRow row)
    {
        row["Id"] = this.Id;
        row["Name"] = this.Name;
        row["Zipcode"] = this.Zipcode;
        row["Rating"] = this.Rating;
        row["Review"] = this.Review;
        row["TotalRatings"] = this.TotalRatings;
    }

    /*
    
    public static implicit operator Restaurant(Restaurant x)
    {
        throw new NotImplementedException();
    }
    */
}