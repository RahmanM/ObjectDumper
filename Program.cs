/*
 * Created by SharpDevelop.
 * User: rahman
 * Date: 16/10/2016
 * Time: 1:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ObjectDumper
{
	class Program
	{
		public static void Main(string[] args)
		{
			var emp = new Employee(){
				FirstName = "Rahman",
				LastName = "Mahmoodi",
				DateOfBirth = DateTime.Now
			};
			
			var str = ObjectDumper<Employee>.Dump(emp);
			
			Console.Write(str);
			Console.ReadKey(true);
		}
	}
	
	public class Employee{
		public string  FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public DateTime DateOfBirth { get; set; }
	}
	
}