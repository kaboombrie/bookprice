/* Brie Prater
07/09/2020
CIS 353
Professor Cain
Assignment 6.2 A */

using System;
using System.Collections.Generic;
using System.Text;
namespace CIS353
{
	public class Book // Book class
	{
		string _title; // holds variables 
		string _author;
		double _price;
		int _numPages;
		public string Title // _title accessors
		{
			get { return _title; }
			set { _title = value; }
		}
		public string Author // _author accessors
		{
			get { return _author; }
			set { _author = value; }
		}
		public double Price // _price accesors
		{
			get { return _price; }
			set { _price = value; }
		}
		public int Pages // _numPages accessors
		{
			get { return _numPages; }
			set { _numPages = value; }
		}
		public void BookEx(string Title, double Price, int Pages) // method to determine if price ratio is correct, passes title, price and pages
		{
			if (Price > 0.10 * Pages) // flags books that have an invalid ratio
			{
				throw (new BookException("For " + Title + ", ratio is invalid. \n Price is $" + Price + " for " + Pages + " pages.")); // throws exception message if ratio is invalid
			}
		}
	}
	public class BookException : Exception // exception class for BookException
	{
		public BookException(string message) : // derives exception with message
			base(message)
		{ }
	}
	public class Test // Test class
	{
		public static void Main(string[] args) // main method
		{
			Book one = new Book(); // instantiates Book 
			one.Title = "Hello World"; // uses constructor to set _title value 
			one.Author = "Brie Prater"; // uses constructor to set _author value
			one.Price = 10.00; // uses constructor to set _price value
			one.Pages = 15; // uses constructor to set _numPages value
			try
			{
				one.BookEx(one.Title, one.Price, one.Pages); // calls BookEx method and passes Title, Price, Pages variables
			}
			catch (BookException e) // throws error
			{
				Console.WriteLine(e.Message); // displays predefined exception message with current variables
			}
			Book two = new Book(); // instantiates new Book
			two.Title = "Lord of the Rings";
			two.Author = "J.R.R. Tolkein";
			two.Price = 5.00;
			two.Pages = 300;
			try
			{
				two.BookEx(two.Title, two.Price, two.Pages); // calls BookEx and passes Book two variables
			}
			catch (BookException e) // throws error
			{
				Console.WriteLine(e.Message); // displays predefined exception message with current variables
			}
			Book three = new Book(); // instantiates new Book
			three.Title = "The Very Hungry Caterpillar";
			three.Author = "Eric Carle";
			three.Price = 13.50;
			three.Pages = 25;
			try
			{
				three.BookEx(three.Title, three.Price, three.Pages); // calls BookEx and passes Book three variables
			}
			catch (BookException e) // throws error
			{
				Console.WriteLine(e.Message); // displays predefined exception message with current variables
			}
			Book four = new Book(); // instantiates new Book
			four.Title = "The Cat in the Hat";
			four.Author = "Dr. Seuss";
			four.Price = 2.00;
			four.Pages = 30;
			try
			{
				four.BookEx(four.Title, four.Price, four.Pages); // calls BookEx and passes Book four variables
			}
			catch (BookException e) // throws error
			{
				Console.WriteLine(e.Message); // displays predefined exception message with current variables
			}
		}
	}
}