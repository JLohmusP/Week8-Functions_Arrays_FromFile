using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}.");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Sprite", "Coca-Cola", "Fanta", "Orange Juice", "Water" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrinks = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrinks}.");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Die Hard", "Terminator", "Grinch", "Home Alone", "Harry Potter" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovies = movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovies}.");
        }
    }
}
