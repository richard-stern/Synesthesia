using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

public class SaveData
{
	private const string m_strDirectory = "\\Synesthesia";
	private const string m_strFileName = "\\Settings.xml";

	public Point m_FormPos;
	public Size m_FormSize;
	public int[] m_nDeviceIndex = new int[Synesthesia.Synesthesia.CAM_VIEWER_COUNT];
	public bool m_bAlwaysOnTop;
	public bool m_bSnapToEdge;

	private string GetDirectory()
	{
		string strPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		return strPath + m_strDirectory;
	}

	private string GetFullPath()
	{
		string strPath = GetDirectory();
		return strPath + m_strFileName;
	}

	public void Save()
	{
		if(!Directory.Exists(GetDirectory()))
		{
			Directory.CreateDirectory(GetDirectory());
		}

		XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
		TextWriter textWriter = new StreamWriter(GetFullPath());
		serializer.Serialize(textWriter, this);
		textWriter.Close();
	}

	public bool Load()
	{
		if(File.Exists(GetFullPath()))
		{
			XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
			TextReader textReader = new StreamReader(GetFullPath());
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
