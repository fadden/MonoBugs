using System;
using System.Windows.Forms;

namespace ListViewCrash2 {
    public partial class LVC2Main : Form {
        public LVC2Main() {
            InitializeComponent();

            // Clear the items from a virtual ListView that has no items.  This should do
            // nothing; instead it crashes.
            listView1.Items.Clear();
        }
    }
}
