using AForge.Video;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------
class CamViewer
{
	private PictureBox m_PictureBox = null;
	private VideoSource m_VideoSource = null;
	private bool m_bPlaying = false;
	private int m_nDeviceIndex = -1;

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public CamViewer()
	{
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public void Play()
	{
		if(m_VideoSource != null)
		{
			m_VideoSource.SetFrameEventCallback(Repaint);
			m_VideoSource.Start();
			m_bPlaying = true;
		}
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public void Stop()
	{
		if(m_VideoSource != null)
		{
			m_VideoSource.Stop();
			m_bPlaying = false;
			m_VideoSource.RemoveFrameEventCallback(Repaint);
		}
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public void SetPictureBox(PictureBox pictureBox)
	{
		m_PictureBox = pictureBox;
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public void SetDevice(VideoSource videoSource, int nDeviceIndex)
	{
		m_VideoSource = videoSource;
		m_nDeviceIndex = nDeviceIndex;
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public int GetDeviceIndex()
	{
		return m_nDeviceIndex;
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public bool GetInitialised()
	{
		return m_VideoSource != null;
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public bool GetIsPlaying()
	{
		return m_bPlaying;
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	private void Repaint(object sender, NewFrameEventArgs eventArgs)
	{
		Bitmap bitmap = eventArgs.Frame;
		m_PictureBox.Image = (Bitmap)bitmap.Clone();
	}
}
