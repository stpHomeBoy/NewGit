using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
	class Program
	{
		static int Main(string[] args)
		{
			try
			{
				var foo = new Foo();
				foo.Bar = "None";
				Console.WriteLine("Hello {0}, from Git!!!!!", foo.Bar);

				foo.Doit();

				Console.ReadLine();
				return 0;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return 1;
			}
		}
	}


	class Foo
	{
		public string Bar { get; set; }

		public void Doit()
		{
			throw new ArgumentException("Blah Blah not found");
		}
	}
}
