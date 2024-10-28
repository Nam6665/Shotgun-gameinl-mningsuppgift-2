namespace Shotgun_gameinlämningsuppgift_2
{
    internal class GameLogic
    {
        GameData gameData = new GameData();

        public GameLogic(GameData data)
        {
            this.gameData = data;
        }
        public void LoadShotgubPlayer()
        {
            ++gameData.bulletsAmountPlayer;
        }
        public void ShootShotgunPlayer()
        {
            gameData.bulletsAmountPlayer -= 3;
            gameData.shootBulletPlayer = true;
            ++gameData.playerWins;

        }
        public void PlayerBlockedShot()
        {
            gameData.bulletsAmountPlayer -= 3;
        }
        public void PlayerBlock()
        {
            gameData.playerBlock = true;
        }
    }
}
