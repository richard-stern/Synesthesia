namespace CamViewer
{
	partial class CamViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CamViewer));
			this.PowerButton = new System.Windows.Forms.Button();
			this.Viewer = new System.Windows.Forms.PictureBox();
			this.DeviceList = new System.Windows.Forms.ComboBox();
			this.ToolBar = new System.Windows.Forms.ToolStrip();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.Viewer)).BeginInit();
			this.ToolBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// PowerButton
			// 
			this.PowerButton.Location = new System.Drawing.Point(194, 44);
			this.PowerButton.Name = "PowerButton";
			this.PowerButton.Size = new System.Drawing.Size(91, 23);
			this.PowerButton.TabIndex = 1;
			this.PowerButton.Text = "Start";
			this.PowerButton.UseVisualStyleBackColor = true;
			this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
			// 
			// Viewer
			// 
			this.Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Viewer.Location = new System.Drawing.Point(12, 87);
			this.Viewer.Name = "Viewer";
			this.Viewer.Size = new System.Drawing.Size(640, 432);
			this.Viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Viewer.TabIndex = 2;
			this.Viewer.TabStop = false;
			// 
			// DeviceList
			// 
			this.DeviceList.FormattingEnabled = true;
			this.DeviceList.Location = new System.Drawing.Point(12, 46);
			this.DeviceList.Name = "DeviceList";
			this.DeviceList.Size = new System.Drawing.Size(176, 21);
			this.DeviceList.TabIndex = 3;
			// 
			// ToolBar
			// 
			this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripButton2,
            this.toolStripButton3});
			this.ToolBar.Location = new System.Drawing.Point(0, 0);
			this.ToolBar.Name = "ToolBar";
			this.ToolBar.Size = new System.Drawing.Size(664, 25);
			this.ToolBar.TabIndex = 4;
			this.ToolBar.Text = "Tool Bar";
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButton1.Text = "toolStripSplitButton1";
			// 
			// toolStripSplitButton2
			// 
			this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
			this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton2.Name = "toolStripSplitButton2";
			this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButton2.Text = "toolStripSplitButton2";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			// 
			// CamViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 531);
			this.Controls.Add(this.ToolBar);
			this.Controls.Add(this.DeviceList);
			this.Controls.Add(this.Viewer);
			this.Controls.Add(this.PowerButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CamViewer";
			this.Text = "Synesthesia";
			this.Move += new System.EventHandler(this.CamViewer_Move);
			((System.ComponentModel.ISupportInitialize)(this.Viewer)).EndInit();
			this.ToolBar.ResumeLayout(false);
			this.ToolBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button PowerButton;
		private System.Windows.Forms.PictureBox Viewer;
		private System.Windows.Forms.ComboBox DeviceList;
		private System.Windows.Forms.ToolStrip ToolBar;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
	}
}

