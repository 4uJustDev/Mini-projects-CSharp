using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Exam
{
    public partial class Form1 : Form
    {
        int heightHex = 10;
        int widthHex = 10;
        int locX = 0;
        int locY = 0;
        int widthOfButton = 30;
        int heightOfButton = 30;
        int countTrue = 0;
        int countFalse = 0;
        bool trueOrFalse = true;
        bool changeOrNot = false;
        int Lvl = 1;
        int countIteration = 0;
        bool plusOrMinus = true;
        Button[,] btnHex1 = new Button[10, 10];
        Button[,] btnHex2 = new Button[10, 10];
        Random rand = new Random();
        private DateTime startTimerUp = DateTime.Now;

        private void btnNo_Click(object sender, EventArgs e)
        {
            calculate();
            if (plusOrMinus)
            {
                countFalse++;
            }
            else
            {
                countTrue++;
            }

            if (countTrue < 4)
            {
                Lvl = 1;
            }
            if (countTrue > 4 && countTrue < 6)
            {
                Lvl = 2;
            }
            if (countTrue >= 6 && countTrue < 8)
            {
                Lvl = 3;
            }
            if (countTrue >= 8)
            {
                Lvl = 4;
            }

            if (rand.Next(0, 2) == 0)
            {
                changeOrNot = false;
            }
            else
            {
                changeOrNot = true;
            }
            counterText.Text = $"Верно/неверно: {countTrue} / {countFalse}";
            lvlText.Text = "Lvl: " + Lvl;
            generate(changeOrNot);
            countIteration = 0;
            plusOrMinus = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            calculate();
            if (plusOrMinus)
            {
                countTrue++;
            }
            else
            {
                countFalse++;
            }

            if (countTrue < 4)
            {
                Lvl = 1;
            }
            if (countTrue > 4 && countTrue < 6)
            {
                Lvl = 2;
            }
            if (countTrue >= 6 && countTrue < 8)
            {
                Lvl = 3;
            }
            if (countTrue >= 8)
            {
                Lvl = 4;
            }
            if (rand.Next(0, 2) == 0)
            {
                changeOrNot = false;
            }
            else
            {
                changeOrNot = true;
            }
            counterText.Text = $"Верно/неверно: {countTrue} / {countFalse}";
            lvlText.Text = "Lvl: " + Lvl;
            generate(changeOrNot);
            countIteration = 0;
            plusOrMinus = true;

        }

        public Button btnForPanelArray1(Button btn, int locationOnX, int locationOnY, int width, int height, EventHandler e)
        {
            btn = new Button();


            btn.BackColor = Color.Aqua;
            btn.Location = new Point(locationOnX, locationOnY);
            btn.Size = new Size(width, height);
            btn.Click += e;

            panelForArray1.Controls.Add(btn);
            
            return btn;
        }
        public Button btnForPanelArray2(Button btn, int locationOnX, int locationOnY, int width, int height, EventHandler e)
        {
            btn = new Button();

            btn.BackColor = Color.Aqua;
            btn.Location = new Point(locationOnX, locationOnY);
            btn.Size = new Size(width, height);
            btn.Click += e;

            panelForArray2.Controls.Add(btn);
            return btn;
        }

        public void clickOnButton1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Yellow;

            this.Refresh();
            MessageBox.Show("Hi");
        }
        public void clickOnButton2(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Black;

            this.Refresh();
            MessageBox.Show("Hello");
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            
            for (int i = 0; i < widthHex; i++)
            {
                for (int j = 0; j < heightHex; j++)
                {
                    Button btn = new Button();
                    btnHex1[i, j] = btnForPanelArray1(btn, locX, locY, widthOfButton, heightOfButton, clickOnButton1);
                    locX += widthOfButton;

                }
                locX = 0;
                locY += heightOfButton;
            }
            locX = 0; locY = 0;
            for (int i = 0; i < widthHex; i++)
            {
                for (int j = 0; j < heightHex; j++)
                {
                    Button btn = new Button();
                    btnHex2[i, j] = btnForPanelArray2(btn, locX, locY, widthOfButton, heightOfButton, clickOnButton2);
                    locX += widthOfButton;

                }
                locX = 0;
                locY += heightOfButton;
            }
            
            generate(changeOrNot);

                   
        }

        public void generate(bool changeOrNotarg)
        {
            int numberForBlackCell = 14; // Увеличиваем кол-во черных клеток
            int numberForBrownCell = 3; // Увеличиваем кол-во коричневых кнопок
            int numberOfIterations = 100;
            int numberForCheck = 15; // 
            if(Lvl == 2)
            {
                numberForBlackCell = 10;
            }
            if (Lvl == 3)
            {
                numberForBlackCell = 5;
            }
            if (Lvl == 4)
            {
                numberForBlackCell = 3;
            }
            for (int i = 0; i < widthHex; i++)
            {
                for (int j = 0; j < heightHex; j++)
                {
                    btnHex1[i, j].BackColor = Color.Green;
                    if (rand.Next(1, numberForBlackCell) == 1)
                    {
                        btnHex1[i, j].BackColor = Color.Black;
                    }
                }
            }
            if (changeOrNotarg)
            {
                for (int i = 0; i < widthHex; i++)
                {
                    for (int j = 0; j < heightHex; j++)
                    {
                        btnHex2[i, j].BackColor = btnHex1[i, j].BackColor;

                        if (rand.Next(0, numberForCheck) == 0)
                        {
                            if (countIteration < numberOfIterations)
                            {
                                if (rand.Next(1, numberForBrownCell) == 1)
                                {
                                    btnHex2[i, j].BackColor = Color.Brown;
                                }
                                countIteration++;
                            }
                        }                        
                    }
                }
            }
            else
            {
                for (int i = 0; i < widthHex; i++)
                {
                    for (int j = 0; j < heightHex; j++)
                    {
                        btnHex2[i, j].BackColor = btnHex1[i, j].BackColor;
                    }
                        countIteration++;

                }
            }
        }
        public void calculate()
        {
            for (int i = 0; i < widthHex; i++)
            {
                for (int j = 0; j < heightHex; j++)
                {
                    if(btnHex1[i, j].BackColor != btnHex2[i, j].BackColor)
                    {
                        plusOrMinus = false;
                    }
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = (DateTime.Now - startTimerUp).ToString(@"mm\:ss\.fff");
        }
    }
}
