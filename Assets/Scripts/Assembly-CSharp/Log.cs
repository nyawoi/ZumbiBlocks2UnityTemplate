using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
	public static Log instance;

	public List<string> networkLog;

	public bool disable;

	public void Init()
	{
	}

	public void AddNetworkLog(string log)
	{
	}

	public void DumpNetworkLog(string path)
	{
	}
}
