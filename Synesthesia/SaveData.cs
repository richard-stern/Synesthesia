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
	private const string m_strFileName = "Settings.xml";

	public Point m_FormPos;
	public Size m_FormSize;
	public int[] m_nDeviceIndex = new int[Synesthesia.Synesthesia.CAM_VIEWER_COUNT];
	public bool m_bAlwaysOnTop;
	public bool m_bSnapToEdge;

	public void Save()
	{
		XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
		TextWriter textWriter = new StreamWriter(m_strFileName);
		serializer.Serialize(textWriter, this);
		textWriter.Close();
	}

	public bool Load()
	{
		if(File.Exists(m_strFileName))
		{
			XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
			TextReader textReader = new StreamReader(m_strFileName);
			SaveData save = (SaveData)serializer.Deserialize(textReader);
			textReader.Close();

			m_FormPos = save.m_FormPos;
			m_FormSize = save.m_FormSize;
			m_nDeviceIndex = save.m_nDeviceIndex;
			m_bAlwaysOnTop = save.m_bAlwaysOnTop;
			m_bSnapToEdge = save.m_bSnapToEdge;

			return true;
		}

		return false;
	}
}
