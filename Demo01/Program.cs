using Demo01.Encapsulation;
using Demo01.Indexer;
using Demo01.Struct;

namespace Demo01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Struct

			#region Example 01
			//// 100 LE

			//Coin c01; // Struct Value Type
			//		  // Decalre For Variable Of Type "Coin"
			//		  // 8 Bytes At STACK
			//		  // 4 Bytes For Int
			//		  // 4 Bytes For Reference String

			//c01 = new Coin();
			//// 'new' --> Just For Constructor Selection/
			//// Calling Default Constructor (Parameterless ctor):
			//// Value = 0
			//// Currency = null

			//Coin c02 = new Coin(100, "USD");

			//Coin c03 = new Coin(200);
			//Coin c04 = new Coin("USD");

			//Console.WriteLine(c01);
			//Console.WriteLine(c02);
			//Console.WriteLine(c03);
			//Console.WriteLine(c04); 
			#endregion

			#region Example 02 (Struct Copy Value)
			//Coin c01 = new Coin(200, "LE");

			//Console.WriteLine(c01);

			//Coin c02 = new Coin(100, "LE");

			//Console.WriteLine(c02);

			//c02 = c01;

			//Console.WriteLine("************* After Assign *************");

			//Console.WriteLine(c01);
			//Console.WriteLine(c02);

			//c02.value = 500;
			//c02.currency = "USD";


			//Console.WriteLine("************* After Change *************");

			//Console.WriteLine(c01); // 200 - LE
			//Console.WriteLine(c02); // 500 - USD 

			#endregion

			#endregion

			#region Encapsulation

			#region Example 01 
			//Employee Emp01 = new Employee(10, "Mohamed", 5000);

			////Emp01.id = 20;
			////Console.WriteLine(Emp01.id);

			////Emp01.SetName("Mohamed Ahmed Amr Mahmoud Emad");           // Set NAme Using Setter MEthod
			////Console.WriteLine(Emp01.GetName()); // Get NAme Using Getter MEthod

			//Console.WriteLine(Emp01.Salary);

			//Emp01.Salary = 8_000;          // SET Salary Using Property
			//Console.WriteLine(Emp01.Salary);// GET Salary Using Property


			////Console.WriteLine(Emp01); 
			#endregion

			#region Types Of Properties
			//Employee employee = new Employee(10, "Ahmed", 11000, 25, 50, "25", DateTime.Now, "HR")
			//{
			//	// Salary = 30000
			//	// EmpId = 100 // Invalid ReadOlny
			//	NationalId = "26",
			//	Age = 30,
			//	// HireDate = new DateTime(2025, 11, 26) // Invalid

			//	Department = "HR"
			//};


			//employee.Age = 40;
			//Console.WriteLine(employee.Age);
			//employee.NationalId = "46555";
			//Console.WriteLine(employee.NationalId); // Invalid

			// employee.EmpId = 20; // Invalid
			//Console.WriteLine(employee.EmpId);

			//employee.HireDate = DateTime.Now;
			//Console.WriteLine(employee.HireDate);
			// Console.WriteLine(employee.Deduction);

			////employee.Department = "IT";
			//Console.WriteLine(employee.Department); 
			#endregion

			#region Indexer
			//PhoneNoteBook Note = new PhoneNoteBook(3);

			//Note.AddNewPerson(0, "Ahmed", 123);
			//Note.AddNewPerson(1, "Aya", 456);
			//Note.AddNewPerson(2, "Omar", 789);

			////Note.SetPersonNumber("Aya", 1000);
			////Console.WriteLine(Note.GetPersonNumber("Aya"));

			////Note["Omar"] = 999;
			////Console.WriteLine(Note["Omar"]);

			//for(int i = 0; i < Note.Size; i++)
			//{
			//	Console.WriteLine(Note[i]);
			//}

			////string name = "Doaa";
			////// name[0] = "jd";
			////Console.WriteLine(name[0]); 
			#endregion


			#endregion


		}
	}
}
