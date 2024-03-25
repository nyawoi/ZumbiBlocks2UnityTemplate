using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StatsAndInfo
{
	[Serializable]
	public class InfoGatherer : MonoBehaviour
	{
		public enum InfoType
		{
			FPS = 0,
			FPSMin = 1,
			FPSMax = 2,
			FPSAvg = 3,
			GPU = 4,
			GPUMemory = 5,
			CPU = 6,
			CPUCores = 7,
			CPUFrequency = 8,
			RAMTotal = 9,
			RAMAlloc = 10,
			OperatingSystem = 11,
			DeviceModel = 12
		}

		public bool showOnStart;

		public bool saveMinMaxAvgData;

		[Tooltip("How many times should the info get updated")]
		public int updateFrequency;

		[HideInInspector]
		public int dataAmount;

		[HideInInspector]
		public int fpsWarningLimit;

		[HideInInspector]
		public int totalFPS;

		[HideInInspector]
		public bool fpsWarning;

		[HideInInspector]
		public Color fpsWarningColor;

		[HideInInspector]
		public Color fpsInitialColor;

		[HideInInspector]
		public List<Action> actions;

		[HideInInspector]
		public Text[] texts;

		private int fps;

		private int min;

		private int max;

		private int avg;

		private bool init;

		private bool shouldUpdate;

		private float timer;

		private float period;

		private void Initialize()
		{
		}

		private void Update()
		{
		}

		public void Hide()
		{
		}

		public void ResetFPSMin()
		{
		}

		public void ResetFPSMax()
		{
		}

		public void ResetFPSAvg()
		{
		}

		public void Show()
		{
		}

		public void SetFPSWarning(int limit, Color color)
		{
		}

		public bool GetEnabled(InfoType type)
		{
			return false;
		}

		public void SetEnabled(InfoType type, bool enabled, Text text = null)
		{
		}

		private void EnableInfo(Action a, int i, Text text)
		{
		}

		private void DisableInfo(Action a)
		{
		}

		public void UpdateFPS()
		{
		}

		public void UpdateFPSMin()
		{
		}

		public void UpdateFPSMax()
		{
		}

		public void UpdateFPSAvg()
		{
		}

		public void UpdateGPU()
		{
		}

		public void UpdateGPUMem()
		{
		}

		public void UpdateCPU()
		{
		}

		public void UpdateCPUCores()
		{
		}

		public void UpdateCPUFreq()
		{
		}

		public void UpdateRAMTotal()
		{
		}

		public void UpdateRAMAlloc()
		{
		}

		public void UpdateOS()
		{
		}

		public void UpdateDeviceModel()
		{
		}
	}
}
