using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кликер_v2
{
    public partial class FormMain : Form
    {
        public int score = 0;
        public int enemyKilled = 0;
        public int numberEnemy = 0;
        public int levelEnemy = 0;
        public int hpEnemyMax = 10;
        public int hpEnemyNow = 10;
        public int damageEnemy = 5;
        public int hpHeroMax = 100;
        public int hpHeroNow = 100;
        public int heroHealing = 25;
        public int levelEnemyImage = 0;
        public int damageHero = 5;
        public bool heroSword = false;
        public bool heroArmor = false;
        public (int hpEnemy, int damageEnemy, int timer) enemy;
        private List<(int hpEnemy, int damageEnemy, int timer)> enemies = new List<(int hpEnemy, int damageEnemy, int timer)>();


        public FormMain()
        {
            InitializeComponent();
            for (int i = 1; i < 10; i++)
            {
                enemy.damageEnemy = 5*i;
                enemy.hpEnemy = 10*i*i;
                enemy.timer = (int)(timerEnemyAttack.Interval/5*4);
                enemies.Add(enemy);
            }

            enemy = enemies[levelEnemy];
        }

        #region MouseUpDownEnemy

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            labelHpEnemy.BackColor = Color.Red;
            labelNumberKill.BackColor = Color.Red;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            labelHpEnemy.BackColor = Color.FromArgb(255, 128, 128);
            labelNumberKill.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void buttonEnemy_Click(object sender, EventArgs e)
        {
            hpEnemyNow -= damageHero;
            labelHpEnemy.Text = "HP: " + hpEnemyNow;
            if (hpEnemyNow <= 0)
            {
                labelHpEnemy.BackColor = Color.FromArgb(255, 128, 128);
                labelNumberKill.BackColor = Color.FromArgb(255, 128, 128);
                timerEnemyAttack.Stop();
                Task.Delay(1000).Wait();
                EnemyDied();
            }
        }
        #endregion

        #region MouseUpDownHero

        private void buttonHero_MouseDown(object sender, MouseEventArgs e)
        {
            labelHpHero.BackColor = Color.Lime;
        }

        private void buttonHero_MouseUp(object sender, MouseEventArgs e)
        {
            labelHpHero.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void buttonHero_Click(object sender, EventArgs e)
        {
            hpHeroNow += heroHealing;
            if (hpHeroNow > hpHeroMax)
            {
                hpHeroNow = hpHeroMax;
            }
            labelHpHero.Text = "HP: " + hpHeroNow;
        }

        #endregion


        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            timerEnemyAttack.Stop();

        }

        private void timerEnemyAttack_Tick(object sender, EventArgs e)
        {
            hpHeroNow -= damageEnemy;
            labelHpHero.Text = "HP: " + hpHeroNow;
            if (hpHeroNow <= 0)
            {
                timerEnemyAttack.Stop();
                MessageBox.Show("Вы проиграли!" +
                                "Поражение!");
            }
        }

        public void EnemyDied()
        {
            score += 5 * (levelEnemy+1);
            labelScore.Text = "Score: " + score;
            numberEnemy++;
            if (numberEnemy >= 5)
            {
                numberEnemy = 0;
                levelEnemy++;
                levelEnemyImage = levelEnemy;
                if (levelEnemyImage == 5) levelEnemyImage = 0;
            }
            NewEnemy();
            enemyKilled++;
            labelNumberKill.Text = "Enemy killed: " + enemyKilled;
            timerEnemyAttack.Start();
        }

        public void NewEnemy()
        {
            enemy = enemies[levelEnemy];
            hpEnemyMax = enemy.hpEnemy;
            hpEnemyNow = hpEnemyMax;
            damageEnemy = enemy.damageEnemy;
            labelHpEnemy.Text = "Hp: " + hpEnemyNow;
            timerEnemyAttack.Interval = enemy.timer;
            EnemyImage();
        }

        public void EnemyImage()
        {
            switch (levelEnemyImage)
            {
                case 1:
                    buttonEnemy.BackgroundImage = new Bitmap(Properties.Resources.Enemy1);
                    break;
                case 2:
                    buttonEnemy.BackgroundImage = new Bitmap(Properties.Resources.Enemy2);
                    break;
                case 3:
                    buttonEnemy.BackgroundImage = new Bitmap(Properties.Resources.Enemy3);
                    break;
                case 4:
                    buttonEnemy.BackgroundImage = new Bitmap(Properties.Resources.Enemy4);
                    break;
            }
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + score;
            hpEnemyMax = enemy.hpEnemy;
            hpEnemyNow = hpEnemyMax;
            damageEnemy = enemy.damageEnemy;
            labelHpEnemy.Text = "HP: " + hpEnemyNow;
            hpHeroNow = hpHeroMax;
            labelHpHero.Text = "HP: " + hpHeroNow;
            buttonHero.BackgroundImage = new Bitmap(Properties.Resources.Hero);
            buttonEnemy.BackgroundImage = new Bitmap(Properties.Resources.Enemy1);
        }
    }
}
