public class Program
{
	public static void Main()
	{
		Console.WriteLine("opg 9.3");
		const int xmas = (11 * 30 + 23) * 24 * 60 * 60;//jul udregnet
		const int today = (11 * 30 + 23) * 24 * 60 * 60;// dags dato udregnet
		const int xmasmin = xmas;
		const int xmasmax = xmas + (24 * 60 *60);
		double price = 599.95 * ( ( (xmasmin <= today) && (today <= xmasmax) ) ? 0.7 : 1.0);// hvis alt før ? er sandt udregens del 1, hvis falsk udregnes del 2
		Console.WriteLine(String.Format("{0:0.00}", price) + "kr.");//String.Format ("{0:0.00}" , price) beder C# om at afrunde til 2 decimaler efter komma, fra en standart
		Console.WriteLine();
		Console.WriteLine("opg 9.4");
		uint month = 2;
		switch (month) {
			case 1:
			Console.WriteLine("January");
			Console.WriteLine("has 31 days");
			break;
			case 2:
			Console.WriteLine("February");
			Console.WriteLine("has 28 days");
			break;
			case 3:
			Console.WriteLine("March");
			Console.WriteLine("has 31 days");
			break;
			case 4:
			Console.WriteLine("April");
			Console.WriteLine("has 30 days");
			break;
			case 5:
			Console.WriteLine("May");
			Console.WriteLine("has 31 days");
			break;
			case 6:
			Console.WriteLine("June");
			Console.WriteLine("has 30 days");
			break;
			case 7:
			Console.WriteLine("July");
			Console.WriteLine("has 31 days");
			break;
			case 8:
			Console.WriteLine("August");
			Console.WriteLine("has 31 days");
			break;
			case 9:
			Console.WriteLine("September");
			Console.WriteLine("has 30 days");
			break;
			case 10:
			Console.WriteLine("October");
			Console.WriteLine("has 31 days");
			break;
			case 11:
			Console.WriteLine("November");
			Console.WriteLine("has 30 days");
			break;
			case 12:
			Console.WriteLine("December");
			Console.WriteLine("has 31 days");
			break;
			default:
			Console.WriteLine("I don't understand");
			break;
		}
		Console.WriteLine();
		Console.WriteLine("opg 9.5");
		Months vacation = Months.January;
		if (vacation == Months.October) 
		{
			Console.WriteLine("Fall brake");
		} 
		else if (vacation == Months.December) 
		{
			Console.WriteLine("Christmas brake") ;
		} 
		else if (vacation == Months.April) 
		{
			Console.WriteLine("Easter brake") ;
		} 
		else if (vacation == Months.July) 
		{
			Console.WriteLine("Summer brake") ;
		} 
		else if (vacation == Months.August) 
		{
			Console.WriteLine("Summer brake") ;
		} 
		else 
		{
			Console.WriteLine("Hard Work");
		}
	}
}
enum Months {
			January,
			February,
			March,
			April,
			May,
			June,
			July,
			August,
			September,
			October,
			November,
			December,
		}