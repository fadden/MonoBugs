namespace ListViewCrash1 {
    partial class LVC1Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crashButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(13, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(599, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.VirtualMode = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Column Zero";
            this.columnHeader1.Width = -2;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Column One";
            // 
            // crashButton
            // 
            this.crashButton.Location = new System.Drawing.Point(12, 12);
            this.crashButton.Name = "crashButton";
            this.crashButton.Size = new System.Drawing.Size(75, 23);
            this.crashButton.TabIndex = 1;
            this.crashButton.Text = "Crash";
            this.crashButton.UseVisualStyleBackColor = true;
            this.crashButton.Click += new System.EventHandler(this.crashButton_Click);
            // 
            // LVC1Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.crashButton);
            this.Controls.Add(this.listView1);
            this.Name = "LVC1Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button crashButton;
    }
}

