using System;

namespace MyNamespace


{

	interface Learner
	{
		void Study();
		void Read();
	}



	public class Student : Learner
	{
		private string name = "David";
		public int pageNumber = 0;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (value != "David")
				{
					name = value;
				}
			}
		}

		public void Study()
		{
			Console.WriteLine("Reviewing notes");
		}

		public void Read()
		{
			pageNumber++;
		}
	}

	class Program
	{

		static void Main(string[] args)
		{
			Student student = new Student();
			student.Name = "Harry";
			string name = student.Name;
			Console.WriteLine("The Students name is: " + name);

		}

	}








}
