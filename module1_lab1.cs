using System;

namespace Module1_Lab1 {
	public class Car {
		// defining properties
		public string Color { get; set; }
		public int Year { get; set; }
		public int Mileage { get; set; }
	}
	class Program {
		static void Main(string[] args) {
			// var keyword makes the compiler deduce type of object at compile time
			var Car1 = new Car();
			Car1.Color = "white";
			Car1.Year = 2010;
			Car1.Mileage = 11000;

			Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");
		}
	}
}