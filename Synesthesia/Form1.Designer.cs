namespace Synesthesia
{
	partial class Synesthesia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Synesthesia));
			this.Viewer0 = new System.Windows.Forms.PictureBox();
			this.ToolBar = new System.Windows.Forms.ToolStrip();
			this.Camera1Button = new System.Windows.Forms.ToolStripSplitButton();
			this.Camera2Button = new System.Windows.Forms.ToolStripSplitButton();
			this.OnTopButton = new System.Windows.Forms.ToolStripButton();
			this.SnapToEdgeButon = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.SnapShotLabel = new System.Windows.Forms.ToolStripLabel();
			this.Viewer1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Viewer0)).BeginInit();
			this.ToolBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Viewer1)).BeginInit();
			this.SuspendLayout();
			// 
			// Viewer0
			// 
			this.Viewer0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Viewer0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Viewer0.Location = new System.Drawing.Point(12, 28);
			this.Viewer0.Name = "Viewer0";
			this.Viewer0.Size = new System.Drawing.Size(336, 255);
			this.Viewer0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Viewer0.TabIndex = 2;
			this.Viewer0.TabStop = false;
			this.Viewer0.DoubleClick += new System.EventHandler(this.Viewer0_DoubleClick);
			// 
			// ToolBar
			// 
			this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Camera1Button,
            this.Camera2Button,
            this.OnTopButton,
            this.SnapToEdgeButon,
            this.toolStripSeparator1,
            this.SnapShotLabel});
			this.ToolBar.Location = new System.Drawing.Point(0, 0);
			this.ToolBar.Name = "ToolBar";
			this.ToolBar.Size = new System.Drawing.Size(360, 25);
			this.ToolBar.TabIndex = 4;
			this.ToolBar.Text = "Tool Bar";
			// 
			// Camera1Button
			// 
			this.Camera1Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Camera1Button.Image = ((System.Drawing.Image)(resources.GetObject("Camera1Button.Image")));
			this.Camera1Button.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Camera1Button.Name = "Camera1Button";
			this.Camera1Button.Size = new System.Drawing.Size(32, 22);
			this.Camera1Button.Text = "Camera Window 1";
			this.Camera1Button.ButtonClick += new System.EventHandler(this.Camera1Button_ButtonClick);
			// 
			// Camera2Button
			// 
			this.Camera2Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Camera2Button.Image = ((System.Drawing.Image)(resources.GetObject("Camera2Button.Image")));
			this.Camera2Button.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Camera2Button.Name = "Camera2Button";
			this.Camera2Button.Size = new System.Drawing.Size(32, 22);
			this.Camera2Button.Text = "Camera Window 2";
			this.Camera2Button.ButtonClick += new System.EventHandler(this.Camera2Button_ButtonClick);
			// 
			// OnTopButton
			// 
			this.OnTopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OnTopButton.Image = ((System.Drawing.Image)(resources.GetObject("OnTopButton.Image")));
			this.OnTopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OnTopButton.Name = "OnTopButton";
			this.OnTopButton.Size = new System.Drawing.Size(23, 22);
			this.OnTopButton.Text = "Always On Top";
			this.OnTopButton.Click += new System.EventHandler(this.OnTopButton_Click);
			// 
			// SnapToEdgeButon
			// 
			this.SnapToEdgeButon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SnapToEdgeButon.Image = ((System.Drawing.Image)(resources.GetObject("SnapToEdgeButon.Image")));
			this.SnapToEdgeButon.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SnapToEdgeButon.Name = "SnapToEdgeButon";
			this.SnapToEdgeButon.Size = new System.Drawing.Size(23, 22);
			this.SnapToEdgeButon.Text = "Snap To Edge";
			this.SnapToEdgeButon.Click += new System.EventHandler(this.SnapToEdgeButon_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// SnapShotLabel
			// 
			this.SnapShotLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.SnapShotLabel.Name = "SnapShotLabel";
			this.SnapShotLabel.Size = new System.Drawing.Size(203, 22);
			this.SnapShotLabel.Text = "Double click video to take screenshot";
			// 
			// Viewer1
			// 
			this.Viewer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Viewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Viewer1.Location = new System.Drawing.Point(12, 289);
			this.Viewer1.Name = "Viewer1";
			this.Viewer1.Size = new System.Drawing.Size(336, 255);
			this.Viewer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Viewer1.TabIndex = 5;
			this.Viewer1.TabStop = false;
			this.Viewer1.DoubleClick += new System.EventHandler(this.Viewer1_DoubleClick);
			// 
			// Synesthesia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 556);
			this.Controls.Add(this.Viewer1);
			this.Controls.Add(this.ToolBar);
			this.Controls.Add(this.Viewer0);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Synesthesia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Synesthesia";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.Move += new System.EventHandler(this.CamViewer_Move);
			this.Resize += new System.EventHandler(this.Synesthesia_Resize);
			((System.ComponentModel.ISupportInitialize)(this.Viewer0)).EndInit();
			this.ToolBar.ResumeLayout(false);
			this.ToolBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Viewer1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox Viewer0;
		private System.Windows.Forms.ToolStrip ToolBar;
		private System.Windows.Forms.ToolStripSplitButton Camera1Button;
		private System.Windows.Forms.ToolStripSplitButton Camera2Button;
		private System.Windows.Forms.ToolStripButton OnTopButton;
		private System.Windows.Forms.ToolStripButton SnapToEdgeButon;
		private System.Windows.Forms.PictureBox Viewer1;
		private System.Windows.Forms.ToolStripLabel SnapShotLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

