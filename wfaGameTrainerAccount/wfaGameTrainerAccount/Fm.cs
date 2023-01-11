using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace wfaGameTrainerAccount
{
    public partial class Fm : Form
    {
        private readonly Game g;
        int timerCounter = 0;
        public Fm()
        {
            InitializeComponent();
            
            g = new Game();
            g.Change += G_Change;
            g.DoReset();

            buYes.Click += (s, e) => g.DoAnswer(true);
            buNo.Click += (s, e) => g.DoAnswer(false);

            timer1.Interval = 1000; //�������� ����� �������������� 1000 �����������
            timer1.Tick += new EventHandler(timer1_Tick); //������������� �� ������� Tick
            timer1.Start();

        }

        private void G_Change(object? sender, EventArgs e)
        {
            laCorrect.Text = $"����� = {g.CountCorrect}";
            laWrong.Text = $"������� = {g.CountWrong}";
            laCode.Text = g.CodeText;
            Level.Text = g.LevelText;

        }

        private void laCode_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerText.Text = $"The time is: {++timerCounter}";
        }
    }
}