using AForge.Video;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CamViewer
{
	public partial class CamViewer : Form
	{
		private DeviceManager m_DeviceManager = null;
		private bool m_bPlaying = false;
		private int m_nSelectedDevice = -1;
		private int m_nSnapDist = 25;

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		public CamViewer()
		{
			InitializeComponent();
			FormClosing += new FormClosingEventHandler(Form1_FormClosing);
			
			Screen myScreen = Screen.FromControl(this);
			Rectangle area = myScreen.WorkingArea;
			StartPosition = FormStartPosition.Manual;

			int width = 420;
			Location = new Point(area.Width - width, 0);
			Size = new Size(width, 366);

			//Initialise devices
			m_DeviceManager = new DeviceManager();

			int nCount = m_DeviceManager.GetDeviceCount();
			for(int i = 0; i < nCount; ++i)
			{
				VideoSource source = m_DeviceManager.GetDevice(i);
				if(source != null)
				{
					source.SetFrameEventCallback(video_NewFrame);
					DeviceList.Items.Add(source.GetName());
				}
			}
			DeviceList.SelectedIndex = 0;
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(m_bPlaying)
			{
				VideoSource source = m_DeviceManager.GetDevice(m_nSelectedDevice);
				if(source != null)
					source.Stop();
			}
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			Bitmap bitmap = eventArgs.Frame;
			Viewer.Image = (Bitmap)bitmap.Clone();
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void PowerButton_Click(object sender, EventArgs e)
		{
			if(!m_bPlaying)
			{
				m_nSelectedDevice = DeviceList.SelectedIndex;

				VideoSource source = m_DeviceManager.GetDevice(m_nSelectedDevice);
				if(source != null)
				{
					source.Start();
					PowerButton.Text = "Stop";
					m_bPlaying = true;
				}
			}
			else
			{
				VideoSource source = m_DeviceManager.GetDevice(m_nSelectedDevice);
				if(source != null)
				{
					source.Stop();
					PowerButton.Text = "Start";
					Viewer.Image = null;
				}

				m_bPlaying = false;
			}
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private bool CheckForSnap(int pos, int edge)
		{
			int delta = pos - edge;
			return delta < 0 || (delta > 0 && delta <= m_nSnapDist);
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void CamViewer_Move(object sender, EventArgs e)
		{
			Screen screen = Screen.FromPoint(Location);

			if(CheckForSnap(Left, screen.WorkingArea.Left))
				Left = screen.WorkingArea.Left;

			if(CheckForSnap(Top, screen.WorkingArea.Top))
				Top = screen.WorkingArea.Top;

			if(CheckForSnap(screen.WorkingArea.Right, Right))
				Left = screen.WorkingArea.Right - Width;

			if(CheckForSnap(screen.WorkingArea.Bottom, Bottom))
				Top = screen.WorkingArea.Bottom - Height;
		}
	}
}
