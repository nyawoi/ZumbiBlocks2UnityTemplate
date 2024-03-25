using System.Collections.Generic;
using UnityEngine;

public class TestVehicle : MonoBehaviour
{
	public enum DriveMode
	{
		FrontWheelDrive = 0,
		RearWheelDrive = 1,
		AllWheelDrive = 2
	}

	public Rigidbody body;

	public Transform centerOfMass;

	public WheelCollider[] frontWheels;

	public WheelCollider[] rearWheels;

	[Header("Settings")]
	[Range(0.05f, 0.4f)]
	public float drag;

	[Range(100f, 200f)]
	public float torque;

	public DriveMode driveMode;

	[Header("Acceleration")]
	public float torqueLerp;

	public float reverseMaxTorqueMulti;

	[Header("Handbrake")]
	public float brakeLerp;

	public float brakeTorque;

	[Header("Drift")]
	public float driftStiffness;

	public float driftSpeed;

	[Header("Steer")]
	public float steerLerp;

	public float steerAngle;

	[Header("Runtime")]
	public float speed;

	public float zeroToHundredTime;

	public float baseStiffness;

	[Header("Telemetry")]
	public float slipness;

	public float wheelRPS;

	public float wheelSpeed;

	[Range(-50f, 50f)]
	public float speedDelta;

	public float speedRatio;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateDrive(List<WheelCollider> driveWheels)
	{
	}

	private void Steer()
	{
	}

	private void HandBrake()
	{
	}

	private void FixedUpdate()
	{
	}
}
