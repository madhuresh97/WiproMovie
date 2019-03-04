using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    class Movie
    {
        int movieID;
        string movieName, director, producer, cast, story, type;
        double duration;

        Movie(int movieID, string movieName, string director, string producer, string cast, double duration, string story, string type)
        {
            Random rnd = new Random();
            this.movieID = rnd.Next(1000,2000);
            this.movieName = movieName;
            this.director = director;
            this.producer = producer;
            this.cast = cast;
            this.duration = duration;
            this.story = story;
            this.type = type;
        }

        public void DisplayMovieDetails()
        {
            Console.WriteLine("Movie ID: "+ movieID);
            Console.WriteLine("Movie Name: " + movieName);
            Console.WriteLine("Director: " + director);
            Console.WriteLine("Producer: " + producer);
            Console.WriteLine("Cast: " + cast);
            Console.WriteLine("Duration: " + duration);
            Console.WriteLine("Story: " + story);
            Console.WriteLine("Type: " + type);
        }
    }

    class Theatre
    {
        int theatreID;
        string theatreName;
        string city;
        string address;
        int numberOfScreen;
        List<int> screens = new List<int>();

        Theatre(int theatreID, string theatreName, string city, string address, int numberOfScreen, List<int> screens)
        {
            Random rnd = new Random();
            this.theatreID = rnd.Next(1000, 2000);
            this.theatreName = theatreName;
            this.city = city;
            this.address = address;
            this.numberOfScreen = numberOfScreen;

            for (int i = 1; i <= numberOfScreen; i++)
            {
                this.screens.Add(i);
            }
        }

        public void DisplayTheatreDetails()
        {
            Console.WriteLine("Theatre ID: " + theatreID);
            Console.WriteLine("Theatre Name: " + theatreName);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Number of Screens: " + numberOfScreen);
        }
    }

    class Screen
    {
        int screenID;
        SortedList<int, string> seats = new SortedList<int, string>();

        public Screen(int screenID, SortedList<int, string> seats)
        {
            this.screenID = 1000;
            for (int i = 1; i <= 50; i++)
            {
                this.seats.Add(i, "Vacant");
            }
        }
    }

    class Show
    {
        int ShowID;
        int MovieID;
        int TheatreID;
        int ScreenID;
        DateTime StartDate;
        DateTime EndDate;
        decimal PlatinumSeatRate;
        decimal GoldSeatRate;
        decimal SilverSeatRate;

        public Show(int ShowID, int MovieID, int TheatreID, int ScreenID, DateTime StartDate, DateTime EndDate, decimal PlatinumSeatRate, decimal GoldSeatRate, decimal SilverSeatRate)
        {
            Random rnd = new Random();
            this.ShowID = rnd.Next(1000, 2000);
            this.MovieID = MovieID;
            this.TheatreID= TheatreID;
            this.ScreenID= ScreenID;
            this.StartDate= StartDate;
            this.EndDate=EndDate;
            this.PlatinumSeatRate= PlatinumSeatRate;
            this.GoldSeatRate= GoldSeatRate;
            this.SilverSeatRate= SilverSeatRate;
        }

        public void DisplayShowDetails()
        {
            
            Console.WriteLine("ShowID: " + ShowID);
            Console.WriteLine("MovieID" + MovieID);
            Console.WriteLine("TheatreID" + TheatreID);
            Console.WriteLine("ScreenID" + ScreenID);
            Console.WriteLine("StartDate" + StartDate);
            Console.WriteLine("EndDate" + EndDate);
            Console.WriteLine("PlatinumSeatRate" + PlatinumSeatRate);
            Console.WriteLine("GoldSeatRate" + GoldSeatRate);
            Console.WriteLine("SilverSeatRate" + SilverSeatRate);
        }
    }

    class User
    {
        string username, password, usertype;

        public User(string username, string password, string usertype)
        {
            this.username = username;
            this.password = password;
            this.usertype = usertype;
        }
    }

    class Booking
    {
        int BookingID;
        DateTime BookignDate;
        int ShowID;
        string CustomerName;
        int NumberOfSeats;
        string SeatType;
        decimal Amount;
        string Email;
        string BookingStatus;
        List<int> SeatNumbers = new List<int>();
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
