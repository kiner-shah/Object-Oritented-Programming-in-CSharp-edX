using System;

namespace Module1_Lab1 {
	public class Car {
		// constructors
		public Car() {
			instances++;
		}
		public Car(string color_, int year_) {
			this.Color = color_;
			this.Year = year_;
			instances++;
		}
		public Car(int year_, int mileage_) {
			this.Year = year_;
			this.Mileage = mileage_;
			instances++;
		}
		// defining properties
		public string Color { get; set; }
		public int Year { get; set; }
		public int Mileage { get; set; }

		private static int instances = 0;

		public static int CountCars() {
			return instances;
		}
	}
	class Program {
		static void Main(string[] args) {
			// var keyword makes the compiler deduce type of object at compile time
			var Car1 = new Car();
			Car1.Color = "white";
			Car1.Year = 2010;
			Car1.Mileage = 11000;

			var Car2 = new Car("Red", 2008);
			int carCount = Car.CountCars();
			Console.WriteLine($"There are {carCount} cars on inventory right now.");
		}
	}
}