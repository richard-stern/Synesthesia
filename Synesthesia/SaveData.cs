using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class SaveData
{
	public Point m_FormPos;
	public Size m_FormSize;
	public int[] m_nDeviceIndex = new int[Synesthesia.Synesthesia.CAM_VIEWER_COUNT];
	public bool m_bAlwaysOnTop;
	public bool m_bSnapToEdge;

	public void Save()
	{
		XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
		TextWriter textWriter = new StreamWriter("Settings.xml");
		serializer.Serialize(textWriter, this);
		textWriter.Close();
	}

	public void Load()
	{
		XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
		TextReader textReader = new StreamReader("Settings.xml");
		SaveData save = (SaveData)serializer.Deserialize(textReader);
		textReader.Close();

		m_FormPos = save.m_FormPos;
		m_FormSize = save.m_FormSize;
		m_nDeviceIndex = save.m_nDeviceIndex;
		m_bAlwaysOnTop = save.m_bAlwaysOnTop;
		m_bSnapToEdge = save.m_bSnapToEdge;
	}
}
