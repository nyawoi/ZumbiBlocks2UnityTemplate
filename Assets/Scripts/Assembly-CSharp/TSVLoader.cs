using System;
using UnityEngine;

[Serializable]
public class TSVLoader : MonoBehaviour
{
	[Serializable]
	public class Line
	{
		public string[] splitStr;
	}

	public char[] separator;

	public Line[] lines;

	public bool Load(string path)
	{
		return false;
	}

	public int ColumnCount(int row)
	{
		return 0;
	}

	public int LineCount()
	{
		return 0;
	}

	public string Get(int row, int column)
	{
		return null;
	}
}
