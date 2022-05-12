/*  A simple program that tracks the mouse position

    Although this program is simple by nature, it can be used to
    create powerful applications.
*/

namespace MousePosition
{
    public partial class Form_MousePosition : Form
    {
        public Form_MousePosition()
        {
            InitializeComponent();
        }
        private void Form_MousePosition_Load(object sender, EventArgs e)
        {
            Tracker();
        }
        private async void Tracker()
        {
            while (true)
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;
                SetText(labelX, x.ToString());
                SetText(labelY, y.ToString());

                await Task.Delay(10); //10 milliseconds
            }
        }
        //Tells which method is to be called when an event is triggered
        delegate void SetTextCallback(Label label, string text);
        private void SetText(Label l, string text)
        {
            if (l.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] {l, text});
            }
            else
            {
                l.Text = text;
            }
        }
    }
}