using System;
using System.Windows.Forms;

namespace Shotgun_gameinlämningsuppgift_2
{
    internal class AI
    {
        private GameData gameData;
        private Random random = new Random();

        public AI(GameData data)
        {
            this.gameData = data;
        }
        public void ProcessAIAction()
        {
            string aiAction = RandomAIChoice(gameData.playerBlock);
            MessageBox.Show($"AI chose: {aiAction}");

            if (aiAction == "Shoot (Blocked)")
            {
                MessageBox.Show("You blocked AI's shot! No damage taken.");
            }
            else if (aiAction == "Shoot")
            {
                if (!gameData.playerBlock)
                {
                    MessageBox.Show("AI shot and hit you! You lost.");
                    ++gameData.aiWins;
                    gameData.ResetBullets();
                }
            }
            gameData.playerBlock = false;
        }
        public string RandomAIChoice(bool playerBlocked)
        {
            gameData.aiBlock = false;
            if (gameData.bulletsAmountAI == 0)
            {
                gameData.bulletsAmountAI++;
                return "Load";
            }
            if (gameData.bulletsAmountAI < 3)
            {
                gameData.bulletsAmountAI++;
                return "Load";
            }
            int choice = random.Next(1, 4);
            switch (choice)
            {
                case 1:
                    gameData.bulletsAmountAI++;
                    return "Load";
                case 2:
                    gameData.bulletsAmountAI -= 3;
                    return playerBlocked ? "Shoot (Blocked)" : "Shoot";
                case 3:
                    if (gameData.bulletsAmountPlayer >= 3)
                    {
                        gameData.aiBlock = true;
                        return "Block";
                    }
                    else
                    {
                        gameData.bulletsAmountAI++;
                        return "Load";
                    }
                default:
                    return "Error";
            }

        }
    }
    
}
