using System;
using System.Drawing;
using System.Windows.Forms;

namespace DisappearingMenus {
    public partial class DMMain : Form {
        public DMMain() {
            InitializeComponent();
            listView1.Hide();
            UpdateOwnerDrawLabel();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void showHideButton_Click(object sender, EventArgs e) {
            if (listView1.Visible) {
                listView1.Hide();
            } else {
                listView1.Show();
            }
        }

        private void toggleOwnerDrawButton_Click(object sender, EventArgs e) {
            listView1.OwnerDraw = !listView1.OwnerDraw;
            UpdateOwnerDrawLabel();
        }

        private void UpdateOwnerDrawLabel() {
            ownerDrawStatusLabel.Text = "Currently: " + (listView1.OwnerDraw ? "ON" : "OFF");
        }

        private void listView1_DrawColumnHeader(object sender,
                DrawListViewColumnHeaderEventArgs e) {
            ListView lv = e.Header.ListView;
            string text = lv.Columns[e.ColumnIndex].Text;

            // Adjust rect to match standard control for 10pt fonts, and
            // reserve a couple pixels at the far right end for the separator.
            Rectangle rect = new Rectangle(e.Bounds.X + 3, e.Bounds.Y + 4,
                e.Bounds.Width - 4, e.Bounds.Height - 4);
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis |
                TextFormatFlags.SingleLine;

            TextRenderer.DrawText(e.Graphics, text, lv.Font, rect, lv.ForeColor, flags);

            Pen pen = new Pen(Color.LightGray);
            e.Graphics.DrawLine(pen, e.Bounds.X + e.Bounds.Width - 1, e.Bounds.Y,
                e.Bounds.X + e.Bounds.Width - 1, e.Bounds.Y + e.Bounds.Height);
        }

        private void listView1_DrawItem(object sender,
                DrawListViewItemEventArgs e) {
            ListView lv = e.Item.ListView;
            ListViewItem lvi = e.Item;

            // Set colors based on selection and focus.  We're assuming RowFullSelect=true.
            if (lvi.Selected && lv.Focused) {
                //lvi.BackColor = SystemColors.Highlight;
                lvi.BackColor = Color.Green;       // make it visibly different in OwnerDraw mode
                lvi.ForeColor = lv.BackColor;
            } else if (e.Item.Selected && !lv.Focused) {
                lvi.BackColor = SystemColors.Control;
                lvi.ForeColor = lv.ForeColor;
            } else {
                lvi.ForeColor = lv.ForeColor;
                lvi.BackColor = lv.BackColor;
            }

            e.DrawBackground();

            if ((e.State & ListViewItemStates.Selected) != 0) {
                e.DrawFocusRectangle();
            }

            Rectangle rect = new Rectangle(e.Bounds.X + 3, e.Bounds.Y + 2,
                e.Bounds.Width - 3, e.Bounds.Height - 2);

            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis |
                TextFormatFlags.SingleLine;

            Font font = lv.Font;
            TextRenderer.DrawText(e.Graphics, lvi.Text, font, rect,
                lvi.ForeColor, flags);
        }
    }
}
