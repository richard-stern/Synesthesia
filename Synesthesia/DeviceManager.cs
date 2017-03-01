using AForge.Video.DirectShow;
using System.Collections.Generic;

//------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------
public class DeviceManager
{
	private FilterInfoCollection m_DevicesCollection = null;
	private List<VideoSource> m_VideoSources = new List<VideoSource>();

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public DeviceManager()
	{
		m_DevicesCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
		if(m_DevicesCollection != null)
		{
			for(int i = 0; i < m_DevicesCollection.Count; ++i)
			{
				VideoSource source = new VideoSource(m_DevicesCollection[i].Name, m_DevicesCollection[i].MonikerString);

				m_VideoSources.Add(source);
			}
		}
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public int GetDeviceCount()
	{
		if(m_DevicesCollection != null)
			return m_DevicesCollection.Count;

		return 0;
	}

	//------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------
	public VideoSource GetDevice(int nDeviceIndex)
	{
		if(m_DevicesCollection != null)
			return m_VideoSources[nDeviceIndex];

		return null;
	}
}