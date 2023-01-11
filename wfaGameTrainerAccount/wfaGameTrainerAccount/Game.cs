namespace wfaGameTrainerAccount
{
    internal class Game
    {
        public int CountCorrect { get; private set; } = 0;
        public int CountWrong { get; private set; } = 0;
        public string CodeText { get; private set; } = "";
        public string LevelText { get; private set; } = "";

        private bool answerCorrect;

        public event EventHandler? Change;


        public void DoReset()
        {
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue();
        }

        private void DoContinue()
        {
            Random rnd = new();
            int LVL = 1;
            LevelText = "LVL1";
            if (CountCorrect >= 4 && CountCorrect < 6)
            {
                LevelText = "LVL2";
                LVL = 2;
            }else if (CountCorrect >= 6 && CountCorrect <= 10)
            {
                LevelText = "LVL3";
                LVL = 3;
            }else if (CountCorrect >= 10)
            {
                LevelText = "LVL4";
                LVL = 4;
            }

            if (LVL == 1)
            {
                int xValue1 = rnd.Next(20);
                int xValue2 = rnd.Next(20);
                int xResult = xValue1 + xValue2;
                int xResultNew = xResult;//то, что увидит пользователь
                if (rnd.Next(2) == 1)
                {
                    xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);
                }

                CodeText = $"{xValue1} + {xValue2} = {xResultNew}";
                answerCorrect = xResult == xResultNew;//в answerCorrect запишется xResultNew если он равен xResult
                Change?.Invoke(this, EventArgs.Empty);
            }if(LVL == 2)
            {
                int xValue1 = rnd.Next(30,40);
                int xValue2 = rnd.Next(30,40);
                int xResult = xValue1 + xValue2;
                int xResultNew = xResult;//то, что увидит пользователь
                if (rnd.Next(2) == 1)
                {
                    xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);
                }

                CodeText = $"{xValue1} + {xValue2} = {xResultNew}";
                answerCorrect = xResult == xResultNew;//в answerCorrect запишется xResultNew если он равен xResult
                Change?.Invoke(this, EventArgs.Empty);
            }if(LVL == 3)
            {
                int xValue1 = rnd.Next(20,100);
                int xValue2 = rnd.Next(20,100);
                int xResult = xValue1 + xValue2;
                int xResultNew = xResult;//то, что увидит пользователь
                if (rnd.Next(2) == 1)
                {
                    xResultNew += rnd.Next(1, 7) + (rnd.Next(2) == 1 ? 1 : -1);
                }

                CodeText = $"{xValue1} + {xValue2} = {xResultNew}";
                answerCorrect = xResult == xResultNew;//в answerCorrect запишется xResultNew если он равен xResult
                Change?.Invoke(this, EventArgs.Empty);
            }if(LVL == 4)
            {
                int xValue1 = rnd.Next(40,100);
                int xValue2 = rnd.Next(40,100);
                int xResult = xValue1 * xValue2;
                int xResultNew = xResult;//то, что увидит пользователь
                if (rnd.Next(2) == 1)
                {
                    xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);
                }

                CodeText = $"{xValue1} * {xValue2} = {xResultNew}";
                answerCorrect = xResult == xResultNew;//в answerCorrect запишется xResultNew если он равен xResult
                Change?.Invoke(this, EventArgs.Empty);
            }

        }

        public void DoAnswer(bool v)
        {
            if (v == answerCorrect)
            { 
                CountCorrect++;
                //если пользователь 3 раза ответил правильно, увелич сложность
            }
            else
            {
                CountWrong++;
            }
            DoContinue();
        }
    }
}