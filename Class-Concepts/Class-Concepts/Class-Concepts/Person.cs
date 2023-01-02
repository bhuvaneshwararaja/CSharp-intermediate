using System;
namespace Class_Concepts
{
	public class Person
	{
		public string Firstname;
		public string lastName;
		public int age;
		public List<Order> orders;

		//Constrcutor overloading
		public Person()
		{
			this.orders = new List<Order>();
		}
		public Person(int age):this()
		{
			this.age = age;
		}

		public Person(int age, string firstName, string lastName):this(age)
		{
			this.Firstname = firstName;
			this.lastName = lastName;
		}
	}
}

