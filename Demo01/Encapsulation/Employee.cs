using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01.Encapsulation
{
	internal struct Employee
	{
		public int id;
		private string? empName;
		private decimal empSalary;


		// Encapsulation : Sperate Data Defintion [Attributes] From its Usage[Getter, Setter Methods | Properties]
		public Employee(int id, string? name, decimal salary, int age, int empId, string nID, DateTime hireDate, string department)
		{
			this.id = id;
			SetName(name);
			Salary = salary;
			Age = age;
			EmpId = empId;
			NationalId = nID;
			HireDate = hireDate;
			Department = department;
		}


		#region Apply Encapsulation Using [Setter & Getter Methods]

		// Getter
		public string? GetName()
		{
			return empName;
		}

		// Setter

		public void SetName(string? name)
		{
			this.empName = name?.Length > 10 ? name[..10] : name;
		}

		#endregion

		#region Apply Encapsulation Using [Properties] (Reccommended)  Easy To Use Like Dealing With Attributes

		// 1. Full Property
		public decimal Salary
		{
			get => empSalary;


			set => empSalary = value < 10000 ? 10000 : value;

		}

		#endregion

		#region Automatic Property
		////private int age;
		//// public int Age { get; set; }  // Automatic Property
		//// Compiler Will Generate Hidden Private Attribute

		public int Age { get; set; }


		#endregion

		#region Read Only Prop

		public int EmpId { get; } // ReadOnly

		#endregion

		#region Write Only Prop

		private string nationalId;

		public string NationalId
		{
			set { nationalId = value; }
		}


		#endregion

		#region Prop With Private Set

		public DateTime HireDate { get; private set; }

		#endregion

		#region Computed Prop

		public decimal Deduction
		{
			get { return Salary * 0.1m; }
		}

		#endregion

		#region Expression Boided Prop => 

		public string EmployeeInfo => $"{EmpId} - {empName} - {empSalary} ";



		#endregion

		#region init Prop

		public string Department { get; init; }

		#endregion

		public void Test()
		{
			empSalary = 100;
			Salary = 100;
			// EmpId = 50;
			nationalId = "100";
			NationalId = "200";
			Age = 20;
			HireDate = new DateTime(2026, 11, 23);
			//Department = "Hamda"; // Invalid

		}

		public override string ToString()
		{
			return $"Id = {id} - Name: {empName} - Salary: {Salary:c} ";
		}
	}
}
