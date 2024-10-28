using System;
using System.Windows.Forms;

namespace Shotgun_gameinlämningsuppgift_2
{
    public partial class Main : Form
    {
        GameData gameData;
        GameLogic gameLogic;
        AI ai;

        public Main()
        {
            InitializeComponent();
            gameData = new GameData();
            gameLogic = new GameLogic(gameData);
            ai = new AI(gameData);
        }

        private void LoadShotGunButton_Click(object sender, EventArgs e)
        {
            gameLogic.LoadShotgubPlayer();  
            ai.ProcessAIAction();
            UpdateUI();
        }
        private void shootBullet_Click(object sender, EventArgs e)
        {
            ai.ProcessAIAction();

            if (gameData.bulletsAmountPlayer >= 3 && !gameData.aiBlock)
            {
                gameLogic.ShootShotgunPlayer();
                MessageBox.Show("you shot AI, you win!");
                ResetBulletAmount();
                UpdateUI();

            }
            else if (gameData.bulletsAmountPlayer >= 3 && gameData.aiBlock)
            {
                gameLogic.PlayerBlockedShot();
                MessageBox.Show("AI blocked your shot! No damage dealt.");
                UpdateUI();
            }
            else
            {
                MessageBox.Show("You do not have enough bullets to shoot.");
                UpdateUI();
            }
        }
        private void BlockButton_Click(object sender, EventArgs e)
        {
            gameLogic.PlayerBlock();
            ai.ProcessAIAction();
            MessageBox.Show("You blocked!");
            UpdateUI();
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            ResetBulletAmount();
            gameData.ResetWins();
            UpdateUI();
        }
        private void ResetBulletAmount()
        {
            gameData.ResetBullets();
            UpdateUI();
        }
        private void UpdateUI()
        {
            bulletLabel.Text = gameData.bulletsAmountPlayer.ToString();
            bulletLabel2.Text = gameData.bulletsAmountAI.ToString();
            playerWinsLabel.Text = gameData.playerWins.ToString();
            aiWinsLabel.Text = gameData.aiWins.ToString();
        }
    }
}
