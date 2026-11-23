using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Demo01.Indexer
{
	internal struct PhoneNoteBook
	{

		#region Attributes
		private string[]? names;
		private int[]? numbers;
		#endregion

		#region CTOR
		public PhoneNoteBook(int size)
		{
			this.Size = size;
			names = new string[Size];
			numbers = new int[Size];
		}
		#endregion

		#region Properties

		public int Size { get; }
		#endregion

		#region Methods
		public void AddNewPerson(int position, string name, int number)
		{
			if (names is not null && numbers is not null)
			{
				if (position < Size)
				{
					names[position] = name;
					numbers[position] = number;
				}
			}
		}
		#endregion

		#region Getter & Setter

		// Getter 
		public int GetPersonNumber(string name)
		{
			if(names is not null && numbers is not null)
			{
				for(int i = 0; i < names.Length; i++)
					if (names[i] == name)
						return numbers[i];
			}
			return -1;
		}

		// Setter

		public void SetPersonNumber(string name, int newNumber) // name, Aya 
		{
			if(numbers is not null && names is not null)
			{
				for(int i = 0; i < names.Length; i++)
				{
					if (names[i] == name)
					{
						numbers[i] = newNumber;
						return;
					}
				}
			}
		}

		#endregion

		#region Indexer
		// 3. Indexer: Special Prop

		//Note["Omar"] = 999;

		public int this[string name]
		{
			get
			{
				if (names is not null && numbers is not null)
					for (int i = 0; i < names.Length; i++)
						if (names[i] == name)
							return numbers[i];
				return -1;
			}
			set
			{
				if (numbers is not null && names is not null)
				{
					for (int i = 0; i < names.Length; i++)
					{
						if (names[i] == name)
						{
							numbers[i] = value;
							return;
						}
					}
				}
			}
		}

		public string this[int index]
		{
			get
			{
				if(names is not null && numbers is not null)
				{
					return $"{index + 1} :: {names[index]}  :: {numbers[index]}";
				}

				return string.Empty; // ""
			}


		}


        /// index - Name  - Number
		#endregion
	}
}
