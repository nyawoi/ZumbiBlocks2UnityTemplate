using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BackupController : MonoBehaviour
{
	private struct BackupsInfo
	{
		public int? earliestBackupID;

		public int? latestBackupID;

		public int backupCount;
	}

	[SerializeField]
	private float maxBackupCount;

	[SerializeField]
	private float backupTriggerSeconds;

	[SerializeField]
	private float backupTriggerTimer;

	public string backupFolderPath;

	private DirectoryInfo backupFolder;

	private DirectoryInfo zb2Folder;

	private bool working;

	private List<string> relevantFileExtensions;

	public void Initialize(string docsPath, DirectoryInfo zb2Folder, List<string> relevantFileExtensions)
	{
	}

	private void GenerateBackupFolder(string docsPath)
	{
	}

	public void Update()
	{
	}

	public void TriggerBackup()
	{
	}

	private void GenerateBackup()
	{
	}

	private void RemoveBackup(int id)
	{
	}

	private DirectoryInfo GetBackupFolder(int id)
	{
		return null;
	}

	private BackupsInfo GetBackupsInfo()
	{
		return default(BackupsInfo);
	}
}
