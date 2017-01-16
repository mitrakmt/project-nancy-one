using Nancy;

namespace firstNancyProject
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = p => "Hello World!";
		}
	}
}
