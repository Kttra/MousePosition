/*  A similar program to the mouse position program.

    This one uses the mousekeyhook package which
    allows us to change the current position of the mouse.
*/
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;
namespace MouseSetPos
{
    public partial class Form_MouseSetPos : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetCursorPos(int x, int y);
        private IKeyboardMouseEvents mEvents;
        public Form_MouseSetPos()
        {
            InitializeComponent();
        }
        private void UpdateEvents(IKeyboardMouseEvents events)
        {
            mEvents = events;
            mEvents.MouseMove += mEventsMouseMove;
        }
        private void FinishEvents()
        {
            if (mEvents == null)
            {
                return;
            }
            mEvents.MouseMove -= mEventsMouseMove;
            mEvents.Dispose();
            mEvents = null;
        }
        private void mEventsMouseMove(object sender, MouseEventArgs e)
        {
            //labelPos.Text = e.Location.ToString();
            labelPos.Text = String.Format("x={0:0000}; y={0:0000}", e.X, e.Y);

        }
        //Set the cursor to the specificed position
        private void BtnChange_Click(object sender, EventArgs e)
        {
            SetCursorPos(0, 0);
            labelPos.Text = String.Format("x={0:0000}; y={0:0000}", MousePosition.X, MousePosition.Y);
        }
        //Start up the program
        private void Form_MouseSetPos_Load(object sender, EventArgs e)
        {
            FinishEvents();
            UpdateEvents(Hook.GlobalEvents());
        }
    }
}