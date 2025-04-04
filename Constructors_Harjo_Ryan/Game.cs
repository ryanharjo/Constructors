using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Constructors_Harjo_Ryan
{
    internal class Game
    {
        public string title; // Public string field to store the game's title
        public string genre; // Public string field to store the game's genre
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual") // Constructor for the 'Game' class with default parameters
                                                                                       // If no argument is provided, it will default to "Unknown Title" and "Casual"

        {
            title = titleParam; // Assign the value of titleParam to the class's title field
            genre = genreParam; // Assign the value of genreParam to the class's genre field
        }
    }
}
