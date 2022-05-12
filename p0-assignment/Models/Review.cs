using CustomExceptions;
using System.Linq;
using System.Collections.Generic;

namespace Models;

public class Review
{
    //empty constructor
    public int Id { get; set; }
    public int UserId { get; set; }

    // public double Rating { get; set; }
    public string UserReview { get; set; }
    public int TotalRatings { get; set; }

    public double Rating
    {
        get => _rating;
        //For the setter, we are checking that the rating is between 1 and 6
        set
        {
            if (value <= 0 || value > 6)
            {
                throw new InputInvalidException("Rating must be between 1 and 6");
            }
            this._rating = value;
        }
    }

    public double _rating;
    public double AddRating()
    {
        List<double> _rating = new List<double>();
        // object x = rating.Sum(double _rating);
        double rating = Queryable.Average(_rating.AsQueryable());
        return rating;
    }

    // public string _review { get; set; }

    public static double SetRestaurantRating(object value)
    {
        Console.ReadLine();
    }

    public static string SetRestaurantReview(object value)
    {
        Console.ReadLine();
    }

    // public string Review { get; set; }

    //override Review's ToString Method for me here
    //That outputs $"Rating: {review.Rating} \t Note: {review.Note}"

    public override string ToString()
    {
        return $"Rating: {this.Rating}\tReview: {this.UserReview}";
    }

    /*
    //Example of constructor overloading
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Review(double rating)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        this.Rating = rating;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Review(double rating, string note)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        this.Rating = rating;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Review()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }

    */

}