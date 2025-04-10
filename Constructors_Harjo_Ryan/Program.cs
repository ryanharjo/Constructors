namespace Constructors_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Game object with specified title and genre
            Game myGame = new Game("Assassin's Creed Odyssey", "Action-Adventure Role-Playing Game");
            // Print out the title and genre of the 'myGame' object to the console                                                                           
            Console.WriteLine($"Game Title: {myGame.Title} and it is an {myGame.Genre}");

                                                                                         

            // Create another instance of the Game class with different values for title and genre
            Game myGame2 = new Game("God of War Ragnarök", "Third-Person Action-Adventure Game");
            // Print out the title and genre of the 'myGame2' object to the console
            Console.WriteLine($"Game Title: {myGame2.Title} and it is a {myGame2.Genre}");


        }
    }
}
