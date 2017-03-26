namespace TwoPlayersPingPong.Positions
{
    public static class Reposition
    {
        private static readonly Position[] AvailablePositions = new Position[]
        {
            new Position(-1, 0), //up
            new Position(+1, 0), //down
            new Position(0, +1), //right
            new Position(0, -1) //left
        };

        public enum PlayerDirections
        {
            Up,
            Down
        }

        public static Position GetThePlayersBarNewPosition(PlayerDirections direction)
        {
            int index = (int)direction;

            return AvailablePositions[index];
        }
    }
}
