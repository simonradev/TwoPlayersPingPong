namespace TwoPlayersPingPong.Players
{
    using System;
    using TwoPlayersPingPong.Positions;

    public class Player
    {
        private Position[] position;
        private const int BarSize = 5;

        public Player()
        {
            position = new Position[BarSize];
        }

        public virtual void InitializePlayersBar()
        {
            throw new NotImplementedException();
        }

        public virtual void MovePlayersBarUp()
        {

        }

        public virtual void MovePlayersBarDown()
        {

        }
    }
}
