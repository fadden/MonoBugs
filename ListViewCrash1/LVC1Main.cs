using System;
using System.Windows.Forms;

namespace ListViewCrash1 {
    public partial class LVC1Main : Form {
        public LVC1Main() {
            InitializeComponent();

            // For this to work, in the designer you must set:
            // - View = Details
            // - VirtualMode = true
            // - VirtualListSize = 0
            // - The width of the first column to -2 (auto-size)
            //
            // With that, it will crash while trying to determine the column width.  Right
            // now we have the View set to LargeIcon so we can crash on demand instead.
        }

        private void crashButton_Click(object sender, EventArgs e) {
            listView1.View = View.Details;
        }
    }
}
