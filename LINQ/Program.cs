namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create list of video games
            List<string> videoGames = new List<string>
            {
                "Pokemon: Blue Version",
                "Super Smash Bros.",
                "Among Us",
                "Fortnite",
                "Grand Theft Auto V",
                "Minecraft",
                "Super Mario Bros. 3",
                "Animal Crossing: New Horizons",
                "Titanfall 2",
                "Mortal Kombat 11",
                "Mario Kart 8 Deluxe",
                "Donkey Kong",
                "Call of Duty: Black Ops",
                "Halo Infinite",
                "Valorant",
                "Metroid Prime"
            };

            // order the list of games by length of the game's names
            var orderedGames = videoGames.OrderBy(game => game.Length);

            // print ordered list of games
            Console.WriteLine("Ordered List of Games by Name Length:");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }

            // filters games with name containing "of"
            var filteredGames = videoGames.Where(game => game.Contains("Mario"));

            // selects only first 3 chars of each game's name
            var selectedChars = videoGames.Select(game => game.Substring(0, 3));

            // total length of game names
            var totalLength = videoGames.Sum(game => game.Length);

            // avg length of game names
            var averageLength = videoGames.Average(game => game.Length);

            // counts number of games w/ names longer than 20 chars
            var longGamesCount = videoGames.Count(game => game.Length > 15);

            // shortest game name
            var shortestGame = videoGames.Min(game => game.Length);

            // longest game name
            var longestGame = videoGames.Max(game => game.Length);

            // takes first 5 games from ordered list
            var firstFiveGames = orderedGames.Take(5);

            // add new game to end of list
            var newGamesList = videoGames.Append("Super Mario 64");

            // orders list of games alphabetically
            var alphabeticallyOrderedGames = videoGames.OrderBy(game => game);

            Console.WriteLine("\nFiltered Games:");
            foreach(var game in filteredGames)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("\nSelected Characters:");
            foreach (var chars in selectedChars)
            {
                Console.WriteLine(chars);
            }

            Console.WriteLine($"\nTotal Length of Game Names: {totalLength}");
            Console.WriteLine($"Average Length of Game Names: {averageLength}");
            Console.WriteLine($"Number of Games with Names Longer Than 20 Characters: {longGamesCount}");
            Console.WriteLine($"Shortest Game Name: {shortestGame}");
            Console.WriteLine($"Longest Game Name: {longestGame}");

            Console.WriteLine("\nFirst Five Games:");
            foreach (var game in firstFiveGames)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("\nNew Games List:");
            foreach (var game in newGamesList)
            {
                Console.WriteLine(game);
            }


            Console.WriteLine("\nAlphabetically Ordered Games:");
            foreach (var game in alphabeticallyOrderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
