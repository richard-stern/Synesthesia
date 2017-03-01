using AForge.Video;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Synesthesia
{
	public partial class Synesthesia : Form
	{
		const int CAM_VIEWER_COUNT = 2;

		private DeviceManager m_DeviceManager = null;
		private CamViewer[] m_aCamViewer = new CamViewer[CAM_VIEWER_COUNT];
		private int m_nSnapDist = 25;
		private bool m_bSnapEnabled = true;

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		public Synesthesia()
		{
			//WinForms standard initialization
			InitializeComponent();
			FormClosing += new FormClosingEventHandler(Form1_FormClosing);
			
			//Set the starting position
			//InitStartingPos();

			//Initialise devices
			m_DeviceManager = new DeviceManager();
			InitCameraLists();

			//Initialise viewers
			m_aCamViewer[0] = new CamViewer(Viewer0);
			m_aCamViewer[1] = new CamViewer(Viewer1);
			
			//Init other variables
			SnapToEdgeButon.BackColor = Color.Green;
			OnTopButton.BackColor = Color.Green;
			TopLevel = true;
			TopMost = true;
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void InitStartingPos()
		{
			Screen myScreen = Screen.FromControl(this);
			Rectangle area = myScreen.WorkingArea;
			StartPosition = FormStartPosition.Manual;

			int width = 420;
			Location = new Point(area.Width - width, 0);
			Size = new Size(width, 366);
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void InitCameraLists()
		{
			int nCount = m_DeviceManager.GetDeviceCount();
			for(int i = 0; i < nCount; ++i)
			{
				VideoSource source = m_DeviceManager.GetDevice(i);
				if(source != null)
				{
					ToolStripItem button = Camera1Button.DropDownItems.Add(source.GetName());
					button.Tag = i;
					button.Click += Camera1Button_ButtonClick;
					
					button = Camera2Button.DropDownItems.Add(source.GetName());
					button.Tag = i;
					button.Click += Camera2Button_ButtonClick;
				}
			}
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			for(int i = 0; i < CAM_VIEWER_COUNT; ++i)
			{
				bool bPlaying = m_aCamViewer[i].GetIsPlaying();
				if(bPlaying)
				{
					m_aCamViewer[i].Stop();
				}
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
			if(m_bSnapEnabled)
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

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void SnapToEdgeButon_Click(object sender, EventArgs e)
		{
			m_bSnapEnabled = !m_bSnapEnabled;
			if(m_bSnapEnabled)
				SnapToEdgeButon.BackColor = Color.Green;
			else
				SnapToEdgeButon.BackColor = Color.Red;
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void OnTopButton_Click(object sender, EventArgs e)
		{
			TopMost = !TopMost;
			if(TopMost)
				OnTopButton.BackColor = Color.Green;
			else
				OnTopButton.BackColor = Color.Red;
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void Camera1Button_ButtonClick(object sender, EventArgs e)
		{
			ProcessViewerInput(0, sender);
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void Camera2Button_ButtonClick(object sender, EventArgs e)
		{
			ProcessViewerInput(1, sender);
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void ProcessViewerInput(int nViewerId, object sendingButton)
		{
			if(nViewerId >= CAM_VIEWER_COUNT)
				return;

			if(sendingButton == Camera1Button || sendingButton == Camera2Button)
			{
				if(m_aCamViewer[nViewerId].GetInitialised())
				{
					if(m_aCamViewer[nViewerId].GetIsPlaying())
						StopViewer(nViewerId);
					else
						StartViewer(nViewerId);
				}
			}
			else
			{
				if(m_aCamViewer[nViewerId].GetIsPlaying())
					StopViewer(nViewerId);

				ToolStripItem button = sendingButton as ToolStripItem;
				int nDeviceIndex = (int)button.Tag;

				VideoSource source = m_DeviceManager.GetDevice(nDeviceIndex);
				m_aCamViewer[nViewerId].SetDevice(source, nDeviceIndex);

				StartViewer(nViewerId);
			}
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void StartViewer(int nViewerId)
		{
			int nDeviceIndex = m_aCamViewer[nViewerId].GetDeviceIndex();
			m_aCamViewer[nViewerId].Play();
			SetViewerButtonsEnabled(nDeviceIndex, false);
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void StopViewer(int nViewerId)
		{
			int nDeviceIndex = m_aCamViewer[nViewerId].GetDeviceIndex();
			m_aCamViewer[nViewerId].Stop();
			SetViewerButtonsEnabled(nDeviceIndex, true);

			//m_DefaultImage
			//Viewer1.Visible = false;
			//Height -= Viewer1.Height;
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void SetViewerButtonsEnabled(int nButtonIndex, bool bEnabled)
		{
			Camera1Button.DropDownItems[nButtonIndex].Enabled = bEnabled;
			Camera2Button.DropDownItems[nButtonIndex].Enabled = bEnabled;
		}
	}
}
