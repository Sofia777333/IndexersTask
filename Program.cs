using System;
namespace IndexersTask
{
    class Program
    {
        static void Main()
        {
            FootballTeam team = new FootballTeam();

            team[8] = new FootballPlayer("darkkiller2000", 322);
            Console.WriteLine(team[0] is null);

            Console.WriteLine();

            Dictionary dictionary = new Dictionary();

            dictionary.AddWord(new Word("Red", "Красный"));
            dictionary.AddWord(new Word("Green", "Зеленый"));
            Console.WriteLine(dictionary["Red"]);


        }
    }

    class Word
    {
        public string Origin { get; set; }

        public string Translate { get; set; }

        public Word(string origin, string translate)
        {
            Origin = origin;
            Translate = translate;
        }

    }
}







