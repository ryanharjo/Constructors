namespace Constructors_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("Assassin's Creed Odyssey", "Action-Adventure RPG");// Create a new instance of the Game class and initialize it with specific values
                                                                                       // for the title and genre.
            Console.WriteLine($"Game Title: {myGame.title} and it is an {myGame.genre}");// Print out the title and genre of the 'myGame' object to the console
                                                                                         // The $ sign allows for string interpolation, meaning we can embed variables directly inside the string.
            Game myGame2 = new Game("God of War Ragnarök", "Third-Person Action-Adventure");// Create another instance of the Game class with different values for title and genre
            Console.WriteLine($"Game Title: {myGame2.title} and it is a {myGame2.genre}");// Print out the title and genre of the 'myGame2' object to the console


        }
    }
}
