namespace RacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartRaceBTN_Click(object sender, EventArgs e)
        {   
            
            for(int i = 0; i < 1000; i++)
            {
                
            }
            CougarBTN.PointToScreen(new Point(CougarBTN.Left++, CougarBTN.Top));
            
            //int currentPoint = CougarBTN.Location.X;          
        }
    }
}