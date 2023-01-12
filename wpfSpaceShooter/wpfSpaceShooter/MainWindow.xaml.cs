using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;
using System.Xml.Linq;

namespace wpfSpaceShooter
{
    
    public partial class MainWindow : Window
    {
        DispatcherTimer gameTimer = new DispatcherTimer();
        bool moveLeft, moveRight;
        List<Rectangle> itemRemover = new List<Rectangle>();
        Random rand = new Random();
        int enemySpliterCounter = 0;
        int enemyCounter = 100;
        int playerSpeed = 10;
        int limit = 50;
        int score = 0;
        int damage = 0;
        int enemySpeed = 10;
        int bullets = 10; 
        int LvL = 1;
        Rect playerHitBox;

        public MainWindow()
        {
            int i = 0;
            MessageBox.Show("Добро пожаловать в SpaceShooter !" + Environment.NewLine +
                "В этой игре вам необходимо принимать сражения в незабываемых баталиях" + Environment.NewLine +
                "Вы остались одни между врагами и планетой на которой живут ваши близкие" + Environment.NewLine +
                "У вас осталось всего лишь 10 патронов, но не разочаровывайтесь" + Environment.NewLine +
                "С каждого павшего противника в будете получать дополнительные 2 патрона" + Environment.NewLine +
                "Уничтожьте хотя-бы 50 противников до прибытия подкрепления с планеты Земля" + Environment.NewLine +
                "Удачи в бою!" + Environment.NewLine  + 
                "[SPACE] - Стрелять\n" +
                "[<-] - Влево\n" +
                "[->] - Вправо");
            InitializeComponent();
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
            myCanvas.Focus();
            ImageBrush bg = new ImageBrush();
            bg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/space.jpg"));
            bg.TileMode = TileMode.Tile;
            myCanvas.Background = bg;
            ImageBrush playerImage = new ImageBrush();
            playerImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/player.png"));
            player.Fill = playerImage;
        }

        public void GameLoop (object sender, EventArgs e){

            playerHitBox = new Rect(Canvas.GetLeft(player), Canvas.GetTop(player), player.Width, player.Height);

            enemyCounter--;

            scoreText.Content = "Score: " + score;
            damageText.Content = "Damage " + damage; 
            lvlText.Content = "LvL " + LvL;
            bulletsText.Content = "Bullets: " + bullets;
            if (enemyCounter < 0)
            {
                makeEnemies();
                enemyCounter = limit;
            }
            if (moveLeft && Canvas.GetLeft(player) > 0)
            {
                Canvas.SetLeft(player, Canvas.GetLeft(player) - playerSpeed);
            }
            if (moveRight && Canvas.GetLeft(player) + 90 < Application.Current.MainWindow.Width)
            {
                Canvas.SetLeft(player, Canvas.GetLeft(player) + playerSpeed);
            }
            foreach (var x in myCanvas.Children.OfType<Rectangle>())
            {
                if (x is Rectangle && (string)x.Tag == "bullet")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) - 20);

                    Rect bullet = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);
                    if (Canvas.GetTop(x) < 10)
                    {
                        itemRemover.Add(x);                        
                    }
                    foreach (var y in myCanvas.Children.OfType<Rectangle>())
                    {
                        if (y is Rectangle && (string)y.Tag == "enemy")
                        {
                            Rect enemy = new Rect(Canvas.GetLeft(y), Canvas.GetTop(y), y.Width, y.Height);
                            if (bullet.IntersectsWith(enemy))
                            {

                                itemRemover.Add(x);
                                itemRemover.Add(y);
                                bullets += 2;
                                score++;
                            }
                        }

                    }
                }
                if (x is Rectangle && (string)x.Tag == "enemy")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) + enemySpeed);
                    Rect enemy = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    if (Canvas.GetTop(x) + 150 > 700)
                    {
                        itemRemover.Add(x);
                        damage += 10;
                    }
                    if (playerHitBox.IntersectsWith(enemy))
                    {
                        damage += 5;
                        itemRemover.Add(x);
                    }
                }


            }
            //Изменение уровня сложности
            if (score > 20)
            {
                limit = 10;
                LvL = 4;
                enemySpeed = 18;
                playerSpeed = 24;
                lvlText.Foreground = Brushes.Red;
            }
            else if (score > 10)
            {

                LvL = 3;
                limit = 10;
                enemySpeed = 16;
                playerSpeed = 20;
                lvlText.Foreground = Brushes.Yellow;
            }
            else if (score > 5)
            {
                LvL = 2;
                limit = 20;
                enemySpeed = 12;
                playerSpeed = 14;
                lvlText.Foreground = Brushes.White;
            }

            if (damage > 99  || bullets <= 0)
            {
                gameTimer.Stop();
                damageText.Foreground = Brushes.Red;
                MessageBox.Show("GAME OVER!" + Environment.NewLine + "Вы уничтожили " + score + "вражеских единиц");
            }
            if (score>=51)
            {
                gameTimer.Stop();
                MessageBox.Show("Вы продержались! У вас осталось "+ (100-damage) + " здоровья у коробля");
            }
            foreach (Rectangle y in itemRemover)
            {
                myCanvas.Children.Remove(y);
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                moveLeft = true;
            }
            if (e.Key == Key.Right)
            {
                moveRight = true;
            }
        }
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                moveLeft = false;
            }
            if (e.Key == Key.Right)
            {
                moveRight = false;
            }

            if (e.Key == Key.Space && bullets > 0)
            {
                Rectangle newBullet = new Rectangle
                {
                    Tag = "bullet",
                    Height = 20,
                    Width = 5,
                    Fill = Brushes.White,
                    Stroke = Brushes.Red
                };
                Canvas.SetTop(newBullet, Canvas.GetTop(player) - newBullet.Height);

                Canvas.SetLeft(newBullet, Canvas.GetLeft(player) + player.Width / 2);

                myCanvas.Children.Add(newBullet);
                bullets--;
            }
        }

        private void makeEnemies()
        {
            ImageBrush enemySprite = new ImageBrush();

            enemySpliterCounter = rand.Next(1, 5);

            switch (enemySpliterCounter)
            {
                case 1:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/1.png"));
                    break;
                case 2:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/2.png"));
                    break;
                case 3:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/3.png"));
                    break;
                case 4:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/4.png"));
                    break;
                case 5:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/5.png"));
                    break;
                default:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/1.png"));
                    break;
            }

            Rectangle newEnemy = new Rectangle
            {
                Tag = "enemy",
                Height = 50,
                Width = 56,
                Fill = enemySprite
            };


            Canvas.SetTop(newEnemy, -100); 
            Canvas.SetLeft(newEnemy, rand.Next(30, 430));
            myCanvas.Children.Add(newEnemy);
        }
    }
}
