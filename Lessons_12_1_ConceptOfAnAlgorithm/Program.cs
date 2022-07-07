using Lessons_12_1_ConceptOfAnAlgorithm;

internal class Program
{
	static void Main(string[] args)
	{
		List<User> users = new List<User>();
		users.Add(new User() { Login = "NotNerd", Name = "Bill Gates", IsPremium = true });
		users.Add(new User() { Login = "HotFinnishGuy", Name = "Linus Torvalds", IsPremium = true });
		users.Add(new User() { Login = "VasyaFromUryupinsk", Name = "Vasya Petrov", IsPremium = false });

		for (int i = 0; i < users.Count; i++)
		{
			Console.WriteLine($"Hello my friends. Welcome {users[i].Name}");
			if (!users[i].IsPremium)
			{
				ShowAds();
			}
		}
	}
	static void ShowAds()
	{
		Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
		// Остановка на 1 с
		Thread.Sleep(1000);

		Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
		// Остановка на 2 с
		Thread.Sleep(2000);

		Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
		// Остановка на 3 с
		Thread.Sleep(3000);
	}
}





