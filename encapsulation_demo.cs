using System;

namespace MVA_Class_Demo {
	class DrinksMachine {
		// constructor
		public DrinksMachine(string loc, string make_, string model_) {
			// use properties here so as to avoid bypassing any checks which are written in properties
			this.Location = loc;
			this.Make = make_;
			this.Model = model_;
		}

		// private members
		private string location;
		private string make;
		private string model;

		// public properties
		public string Location {
			get { return location; }
			set { location = value; }
		}
		public string Make {
			get { return make; }
			set { make = value; }
		}
		public string Model {
			get { return model; }
			set { model = value; }
		}

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
			DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand1", "DM1000");
			Console.WriteLine(myMachine.Location + " " + myMachine.Make + " " + myMachine.Model);
			myMachine.MakeCappuccino();
			myMachine.MakeEspresso();
		}
	}
}