using AForge.Video;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Synesthesia
{
	public partial class Synesthesia : Form
	{
		const int CAM_VIEWER_COUNT = 2;
		const float INV_ASPECT_RATIO = 1.0f / (4.0f / 3.0f);

		private DeviceManager m_DeviceManager = null;
		private CamViewer[] m_aCamViewer = new CamViewer[CAM_VIEWER_COUNT];
		private PictureBox[] m_aPictureBoxes = new PictureBox[CAM_VIEWER_COUNT];
		private int m_nSnapDist = 25;
		private bool m_bSnapEnabled = true;
		private int m_nViewerAreaTop = 0;
		private int m_nToolBarPadding = 6;

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
			m_aPictureBoxes[0] = Viewer0;
			m_aPictureBoxes[1] = Viewer1;

			for(int i = 0; i < CAM_VIEWER_COUNT; ++i)
			{
				m_aCamViewer[i] = new CamViewer(m_aPictureBoxes[i]);
			}
			
			//Init other variables
			SnapToEdgeButon.BackColor = Color.Green;
			OnTopButton.BackColor = Color.Green;
			TopLevel = true;
			TopMost = true;

			Rectangle screenRectangle = RectangleToScreen(ClientRectangle);
			int nTitleBarHeight = screenRectangle.Top - Top;
			m_nViewerAreaTop = nTitleBarHeight + ToolBar.Height + m_nToolBarPadding;
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void Form1_Shown(Object sender, EventArgs e)
		{
			UpdateLayout();
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
		private void UpdateLayout()
		{
			int nNeededHeight = 0;
			int nVisibleCount = 0;
			for(int i = 0; i < CAM_VIEWER_COUNT; ++i)
			{
				if(m_aPictureBoxes[i].Visible)
				{
					int boxHeight = (int)(Width * INV_ASPECT_RATIO);
					nNeededHeight += boxHeight;
					m_aPictureBoxes[i].Height = boxHeight;
					m_aPictureBoxes[i].Top = m_nViewerAreaTop + (nVisibleCount * boxHeight);
					++nVisibleCount;
				}
			}

			if(nNeededHeight < m_nViewerAreaTop)
				nNeededHeight = m_nViewerAreaTop;
			Height = nNeededHeight;
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void StartViewer(int nViewerId)
		{
			int nDeviceIndex = m_aCamViewer[nViewerId].GetDeviceIndex();
			m_aCamViewer[nViewerId].Play();
			SetViewerButtonsEnabled(nDeviceIndex, false);

			m_aPictureBoxes[nViewerId].Visible = true;
			UpdateLayout();
		}

		//------------------------------------------------------------------------------------
		//------------------------------------------------------------------------------------
		private void StopViewer(int nViewerId)
		{
			int nDeviceIndex = m_aCamViewer[nViewerId].GetDeviceIndex();
			m_aCamViewer[nViewerId].Stop();
			SetViewerButtonsEnabled(nDeviceIndex, true);

			m_aPictureBoxes[nViewerId].Visible = false;
			UpdateLayout();
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
