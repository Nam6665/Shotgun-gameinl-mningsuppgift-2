namespace Shotgun_gameinlämningsuppgift_2
{
    internal class GameData
    {
        public int bulletsAmountPlayer { get; set; }
        public int bulletsAmountAI {  get; set; }
        public int playerWins {  get; set; }
        public int aiWins { get; set; }
        public bool playerBlock { get; set; }
        public bool aiBlock { get; set; }
        public bool shootBulletPlayer { get; set; }

        public GameData()
        {
            ResetBullets();
            ResetWins();
        }
        public void ResetBullets()
        {
            bulletsAmountPlayer = 0;
            bulletsAmountAI = 0;
        }
        public void ResetWins()
        {
            playerWins = 0;
            aiWins = 0;
        }
    }
}