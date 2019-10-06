using System;

namespace MVA_Class_Demo {
	class DrinksMachine {
		// public members
		public string location;
		public string make;
		public string model;

		// public methods
		public void MakeEspresso() {
			Console.WriteLine("Espresso has been made");
		}

		public void MakeCappuccino() {
			Console.WriteLine("Cappuccino has been made");
		}
	}

	class Program {
		static void Main(string[] args) {
			DrinksMachine myMachine = new DrinksMachine();
			myMachine.location = "Kitchen";
			myMachine.model = "DM1000";
			Console.WriteLine(myMachine.location + " " + myMachine.model);
			myMachine.MakeCappuccino();
			myMachine.MakeEspresso();
		}
	}
}