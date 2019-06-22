namespace Ping_Pong_Logic
{
    /// <summary>
    /// Static GlobalVariables class provides difficulty levels for the game.
    /// </summary>
    public static class GlobalVariables
    {
        public static Level[] Levels { get; }

        static GlobalVariables()
        {
            Levels = new Level[5];

            for (int i = 0; i < 5; i++)
            {
                int n = i + 1;
                Levels[i] = new Level(n, n + 5, n + 3, n + 1);
            }
        }
    }

    public class Level
    {
        public int LevelId { get; }
        public int BallVelocityX { get; }
        public int BallVelocityY { get; }
        public int EnemyVelocityY { get; }

        public Level(int id, int ballVelocityX, int ballVelocityY, int enemyVelocityY)
        {
            LevelId = id;
            BallVelocityX = ballVelocityX;
            BallVelocityY = ballVelocityY;
            EnemyVelocityY = enemyVelocityY;
        }
    }
}
