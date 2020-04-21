using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
   
    class SpaceLogic
    {
        public delegate void SpaceEvent();

        public event SpaceLogic Event SpaceMoved;


        Timer timer = new Timer();
        public SpaceLogic()
        {
            timer.Enabled = true;
            timer.Interval = 200;
            timer.Tick += Timer_tick;

        }

        private void Timer_tick(object sender, EventArgs e)
        {
            SpaceMoved();
        }
    }
}
