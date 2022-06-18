using System;
using System.Collections.Generic;
using System.Text;


/* *******************************************************
* CIS123: Intro to Object-oriented Programming
* Murach C#, 7th ed., pp. 425-426
* Chapter 12. How to create & use classes
* Dominique Tepper, 18JUN2022
* 
* Exercise 12-1
* 2. Add a class named Customer and
*      a. Properties
*          1. FirstName
*          2. LastName
*          3. Email
*      b. Method
*          1. GetDisplayText()
*      c.Constructor
*          1. () default
*          2. (firstName, lastName, email)
*          
* Exercise 12-2
* 2a. Modify the Customer class so it defines a structure.
* 2b. Omit the empty constructor.
* ******************************************************/

namespace CustomerMaintenance
{
	/*//2. Customer class
	public class Customer
	{
		//2-c1 default constructor
		public Customer() { }*/

	//Ex12-2, 2a
	//Tepper, 18JUN2022
	public struct Customer
	{ 

		//2-c2 constructor using a tuple
		public Customer(string firstName, string lastName, string email) =>
		(this.FirstName, this.LastName, this.Email) = (firstName, lastName, email);

		//2-a1 FirstName
		public string FirstName { get; set; }

		//2-a2 LastName
		public string LastName { get; set; }

		//2-a3 Email
		public string Email { get; set; }

		//2-b GDT() method
		public string GetDisplayText() => 
			FirstName + " " + LastName + ", " + Email;
	}
}