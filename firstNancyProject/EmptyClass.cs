using Nancy;
using System;

namespace firstNancyProject
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = p => Console.WriteLine("HI");
		}
	}
}
