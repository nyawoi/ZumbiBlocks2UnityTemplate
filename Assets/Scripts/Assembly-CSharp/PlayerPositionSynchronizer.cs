using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionSynchronizer : MonoBehaviour
{
	[Serializable]
	public class PosPack
	{
		public Vector3 pos;

		public float angle;

		public float camAngle;

		public float fightCoef;

		public PosPack(Vector3 p, float a, float camAng, float fightMode)
		{
		}
	}

	public Transform targetTransform;

	public PlayerMain playerMain;

	[Header("Sender")]
	public float timer;

	public float freq;

	[Header("Receiver")]
	public float lerpSpeed;

	public float lerpExtraSpeed;

	public float curLerpT;

	public List<PosPack> posBuffer;

	public int bufferMax;

	[Header("Animation")]
	public Vector3 lastPos;

	public SmoothedVector3 deltaPos;

	[NonSerialized]
	private const float speedCoefLerp = 5f;

	public string[] synchedArmAnimations;

	public string[] synchedLegAnimations;

	public void ReceivePosition(Vector3 pos, float angle, byte camAngle, byte fightMode, byte spineCorrectionInput)
	{
	}

	public void SendUpdate()
	{
	}

	private void CalculateDeltaPosition()
	{
	}

	public void ReceiverUpdate()
	{
	}

	public int GetArmAnimationIndex(string str)
	{
		return 0;
	}

	public int GetLegAnimationIndex(string str)
	{
		return 0;
	}

	private int GetAnimationIndex(string[] strList, string str)
	{
		return 0;
	}

	public void SendAnimation(bool isArms, byte mode, string animName, float param)
	{
	}

	public void ReceiveAnimation(bool isArms, byte mode, byte animationIndex, byte param)
	{
	}

	public void SendRollVector(Vector2 rollVector)
	{
	}

	public void ReceiveRollVector(byte dirIndex)
	{
	}

	public void SendEquipment()
	{
	}

	public void SyncShotOnline(Vector3 shotVector)
	{
	}

	public void SyncHealth(PlayerMain.HealthState health)
	{
	}

	public void ReceiveShotEvent(Vector3 vector)
	{
	}
}
