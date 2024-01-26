using System;
using System.Windows.Forms;

namespace lr16
{
    public partial class RunningText : UserControl
    {
        int posX;
        public RunningText()
        {
            InitializeComponent();
        }

        private void RunningText_Resize(object sender, EventArgs e)
        {
            txt.Top = 0;
            txt.Left = 0;
            txt.Width = Width;
            posX = txt.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt.Top = 0;
            txt.Left = posX;
            //GetNewString(Text);
            posX -= Speed;
            if (posX < 0)
            {
                posX = txt.Width;
            }
        }

        private void RunningText_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        public void GetNewString(string s)
        {
            txt.Text = s;
        }

        public string Text
        {
            set
            {
                txt.Text = value;
                //txt.Text = Text;
            }
            get { return txt.Text; }
        }

        public int Speed=20;
    }
}
