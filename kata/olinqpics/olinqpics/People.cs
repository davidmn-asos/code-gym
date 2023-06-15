namespace olinqpics
{
    public static class People
    {
        private static IEnumerable<Person> Data => new[] 
        { 
            new Person { Name = "Maisy", Gender = Gender.Female, Age = 62, FavouriteColours = new[] { "Green", "Purple", "Orange" } },
            new Person { Name = "Pyotr", Gender = Gender.Male, Age = 25, FavouriteColours = new[] { "Orange" } },
            new Person { Name = "Cameron", Gender = Gender.Male, Age = 37, FavouriteColours = new[] { "Red" } },
            new Person { Name = "Alfred", Gender = Gender.Male, Age = 41, FavouriteColours = new[] { "Blue", "Red" } },
            new Person { Name = "Magda", Gender = Gender.Female, Age = 30, FavouriteColours = new[] { "Red", "Orange", "Purple" } },
            new Person { Name = "June", Gender = Gender.Female, Age = 27, FavouriteColours = new[] { "Red", "Orange", "Blue" } },
            new Person { Name = "Síobhan", Gender = Gender.Female, Age = 60, FavouriteColours = new[] { "Purple", "Pink", "Orange" } },
            new Person { Name = "Selena", Gender = Gender.Female, Age = 49, FavouriteColours = new[] { "Red", "Purple", "Yellow" } },
            new Person { Name = "Mei", Gender = Gender.Female, Age = 17, FavouriteColours = new[] { "Pink" } },
            new Person { Name = "Richard", Gender = Gender.Male, Age = 37, FavouriteColours = new[] { "Purple", "Green", "Orange" } },
            new Person { Name = "Randolf", Gender = Gender.Male, Age = 53, FavouriteColours = new[] { "Purple", "Orange", "Blue" } },
            new Person { Name = "Japji", Gender = Gender.Female, Age = 55, FavouriteColours = new[] { "Pink" } },
            new Person { Name = "Colin", Gender = Gender.Male, Age = 50, FavouriteColours = new[] { "Yellow", "Orange" } },
            new Person { Name = "Alice", Gender = Gender.Female, Age = 47, FavouriteColours = new[] { "Purple", "Orange" } },
            new Person { Name = "Hayao", Gender = Gender.Male, Age = 44, FavouriteColours = new[] { "Yellow" } },
            new Person { Name = "Robin", Gender = Gender.NonBinary, Age = 23, FavouriteColours = new[] { "Blue", "Pink" } }
        };

        public static double AverageAge()
        {
            return 0;
        }


    }
}
