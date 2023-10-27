namespace ThreadingDemonstration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstStartBTN_Click(object sender, EventArgs e)
        {
            Thread load = new Thread(LaunchFirstThread);
            load.Start();
        }

        public void LaunchFirstThread()
        {
            for (int i = 0; i <= 100; i++)
            {
                FirstProcessPB.Value = i;
                Thread.Sleep(250);
            }
        }

        public void LaunchSecondThread()
        {
            for (int i = 0; i <= 100; i++)
            {
                SecondProcessPB.Value = i;
                Thread.Sleep(250);
            }
        }

        private void SecondStartBTN_Click(object sender, EventArgs e)
        {
            Thread load = new Thread(LaunchSecondThread);
            load.Start();
        }
    }
}