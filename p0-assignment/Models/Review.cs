using CustomExceptions;
using System.Linq;
using System.Collections.Generic;

namespace Models;

public class Review
{
    //empty constructor
    public double UserReview()
    {
        List<double> rating = new List<double>();
        object p = rating.AddReview();
        double avg = Queryable.Average(rating.AsQueryable());
        return avg;
    }
    

    //Example of constructor overloading
    public Review(double rating)
    {
        this.Rating = rating;
    }

    public Review(double rating, string note)
    {
        this.Rating = rating;
    }

    public Review()
    {
    }

    public int Id { get; set; }

    private double _rating;

    public double Rating
    {
        get => _rating;
        //For the setter, we are checking that the rating is between 1 and 6
        set
        {
            if(value <= 0 || value > 6)
            {
                throw new InputInvalidException("Rating must be between 1 and 6");
            }
            this._rating = value;
        }
    }
    public string _review { get; set; }
    public string Review { get; set; }

    //override Review's ToString Method for me here
    //That outputs $"Rating: {review.Rating} \t Note: {review.Note}"

    public override string ToString()
    {
        return $"Rating: {this.Rating}\tNote: {this._review}";
    }
}