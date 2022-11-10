using System;


namespace IndexersTask
{
  class FootballPlayer
  {
        public string Name { get; set; }

         public int Number { get; set; }

        public FootballPlayer(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public override string ToString() => $"{Number} : {Name}";


    }
}
