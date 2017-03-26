namespace TwoPlayersPingPong.Players
{
    using System;
    using TwoPlayersPingPong.Positions;
    using TwoPlayersPingPong.GlobalConstants;

    public class Player
    {
        public Position[] barPosition;
        public static readonly int BarSize = 5;
        private const int TopMostElement = 0;
        private const int BotMostElement = 4;

        public Player()
        {
            barPosition = new Position[BarSize];
        }

        public virtual void InitializePlayersBar()
        {
            throw new NotImplementedException();
        }

        public void MovePlayersBarUp()
        {
            if (!MoveIsValid(barPosition[TopMostElement]))
            {
                return;
            }

            UpdateThePlayersBar(Reposition.PlayerDirections.Up);
        }
        
        public void MovePlayersBarDown()
        {
            if (!MoveIsValid(barPosition[BotMostElement]))
            {
                return;
            }

            UpdateThePlayersBar(Reposition.PlayerDirections.Down);            
        }

        private void UpdateThePlayersBar(Reposition.PlayerDirections direction)
        {
            Position newRows = Reposition.GetThePlayersBarNewPosition(direction);

            for (int currPosition = 0; currPosition < barPosition.Length; currPosition++)
            {
                barPosition[currPosition].Row = barPosition[currPosition].Row + newRows.Row;
            }
        }

        private bool MoveIsValid(Position position)
        {
            bool isValid = true;

            if (position.Row == 0 || position.Row == ConsoleManager.MaxWindowRows)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
