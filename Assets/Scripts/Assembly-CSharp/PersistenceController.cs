using System.IO;
using System.Text;
using UnityEngine;

public class PersistenceController : MonoBehaviour
{
	public enum FileID
	{
		SettingsFile = 0,
		ProgressFile = 1
	}

	public enum LoadResult
	{
		Success = 0,
		CantLoad = 1,
		CorruptedSecurity = 2,
		SecurityMismatch = 3
	}

	public static PersistenceController instance;

	[Header("Settings")]
	public int curSaveVersion;

	public string[] fileName;

	public string fileExtension;

	public string securityExtension;

	public BackupController backups;

	public FileSecurityController security;

	public GraphicsMenu graphicsMenu;

	public ControlsMenu controlsMenu;

	public SoundMenu soundsMenu;

	[Header("Runtime")]
	public bool functional;

	public string docsPath;

	public string docsZb2Path;

	private DirectoryInfo docsFolder;

	private DirectoryInfo docsZb2Folder;

	public static Encoding DefaultEncoding => null;

	public void Init()
	{
	}

	public void Launch()
	{
	}

	public void LoadProgression()
	{
	}

	public bool VerifyProgressLoad(SaveProgress saveProgress)
	{
		return false;
	}

	public void LoadSettings()
	{
	}

	public bool VerifySettingsLoad(SaveSettings settings)
	{
		return false;
	}

	public void BuildFolderStructure()
	{
	}

	public static bool CreateFolder(DirectoryInfo dir)
	{
		return false;
	}

	private static void WarnCantCreateFolders()
	{
	}

	public string GetFilePath(FileID id)
	{
		return null;
	}

	public string GetFileJson(FileID id)
	{
		return null;
	}

	public void SaveFile(FileID id, bool print = true)
	{
	}

	public LoadResult LoadFile(FileID id, out string res)
	{
		res = null;
		return default(LoadResult);
	}
}
