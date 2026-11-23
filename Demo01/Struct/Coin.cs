using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01.Struct
{
	internal struct Coin
	{
		// Attributes [Fields, Var]
		// Properties[Full Prop, Auto Prop, Indexer]
		// Constructors
		// Methods

		public int value; // 4 Bytes
		public string currency; // 4 Bytes

		// Constructor: is special Method[Function]
		// 1. [Named always With The Same Name Of Its Class Or Struct] 
		// 2. Has No Return Type
		// By Default At Struct Compiler Will Always Generate Default Ctor [Parameterless]
		
		public Coin(int value, string currency)
		{
			
			this.value = value;
			this.currency = currency;
		}

		//public Coin(int value):this(value, "LE")
		//{
		//	//this.value = value;
		//	//currency = "LE";
		//}
		//public Coin(string currency):this(10, currency)
		//{
			
		//	//this.value = 10;
		//	//this.currency = currency;
		//}


		public override string ToString()
		{
			return $"{value} - {currency}";
		}
	}
}
