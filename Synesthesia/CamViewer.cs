using AForge.Video;
using System;
using System.Drawing;
using System.Windows.Forms;

//------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------
class CamViewer
{
	private PictureBox m_PictureBox = null;
	private VideoSource m_VideoSource = null;
	private Image m_DefaultImage = null;
	private bool m_bPlaying = false;
	private int m_nDeviceIndex = -1;

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public CamViewer(PictureBox pictureBox)
	{
		m_PictureBox = pictureBox;
		m_DefaultImage = m_PictureBox.Image;
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
			m_PictureBox.Image = m_DefaultImage;
			m_bPlaying = false;
			m_VideoSource.RemoveFrameEventCallback(Repaint);
		}
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
		//The AForge library calls this function from a seperate thread.
		//Painting has to happen in an invoked delegate otherwise it's not thread safe.
		try
		{
			if(m_PictureBox.InvokeRequired)
			{
				m_PictureBox.Invoke(new MethodInvoker(
					delegate()
					{
						Bitmap bitmap = eventArgs.Frame;
						m_PictureBox.Image = (Bitmap)bitmap.Clone();
					}
				));
			}
		}
		catch(ObjectDisposedException)
		{
		}
	}
}
