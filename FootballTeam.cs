using System;


namespace IndexersTask
{
    class FootballTeam
    {
        private readonly FootballPlayer[] _players = new FootballPlayer[11];
        public FootballTeam() { }

        public FootballTeam(FootballPlayer[] players)
        {
            if (players.Length != 11)
                throw new ArgumentOutRangeException("Игроков должно быть 11 человек");
            _players = players;
        }
        public FootballPlayer this[int index]
        {
            get => _players[index];
            set => _players[index] = value;
        }
        private bool CheckIfIndexCorrect(int index) => index >= 0 && index <= 10;



    }
}
