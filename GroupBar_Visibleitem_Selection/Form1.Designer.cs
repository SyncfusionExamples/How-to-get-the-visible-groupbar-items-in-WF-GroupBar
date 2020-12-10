
namespace GroupBar_selection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem4 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(220, 300);
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.FlatLook = true;
            this.groupBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBar1.ForeColor = System.Drawing.Color.White;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem2,
            this.groupBarItem3,
            this.groupBarItem4});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 2;
            this.groupBar1.Size = new System.Drawing.Size(220, 300);
            this.groupBar1.SmartSizeBox = false;
            this.groupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.TabIndex = 0;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.ThemeName = "Metro";
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem1.Client = null;
            this.groupBarItem1.Text = "Mail";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem2.Client = null;
            this.groupBarItem2.Text = "Contacts";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem3.Client = null;
            this.groupBarItem3.Text = "Tasks";
            this.groupBarItem3.Visible = false;
            // 
            // groupBarItem4
            // 
            this.groupBarItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem4.Client = null;
            this.groupBarItem4.Text = "Notes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBar1);
            this.Name = "Form1";
            this.Text = "GroupBar_Items";
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem3;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem4;
    }
}

