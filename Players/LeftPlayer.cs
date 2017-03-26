namespace TwoPlayersPingPong.Players
{
    public class LeftPlayer : Player
    {
        public LeftPlayer()
            : base ()
        {

        }

        public override void InitializePlayersBar()
        {
            for (int currRow = 0; currRow < Player.BarSize; currRow++)
            {
                barPosition[currRow].Row = currRow;
                barPosition[currRow].Col = 0;
            }
        }
    }
}
