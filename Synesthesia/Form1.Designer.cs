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
			this.Viewer1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Viewer0)).BeginInit();
			this.ToolBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Viewer1)).BeginInit();
			this.SuspendLayout();
			// 
			// Viewer0
			// 
			this.Viewer0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Viewer0.Location = new System.Drawing.Point(12, 28);
			this.Viewer0.Name = "Viewer0";
			this.Viewer0.Size = new System.Drawing.Size(336, 255);
			this.Viewer0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Viewer0.TabIndex = 2;
			this.Viewer0.TabStop = false;
			// 
			// ToolBar
			// 
			this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Camera1Button,
            this.Camera2Button,
            this.OnTopButton,
            this.SnapToEdgeButon});
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
			// Viewer1
			// 
			this.Viewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Viewer1.Location = new System.Drawing.Point(12, 289);
			this.Viewer1.Name = "Viewer1";
			this.Viewer1.Size = new System.Drawing.Size(336, 255);
			this.Viewer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Viewer1.TabIndex = 5;
			this.Viewer1.TabStop = false;
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
			this.Name = "Synesthesia";
			this.Text = "Synesthesia";
			this.Move += new System.EventHandler(this.CamViewer_Move);
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
	}
}

