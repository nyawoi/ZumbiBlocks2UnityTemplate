using System.Collections.Generic;
using UnityEngine;

public class LobbyObjectMover : MonoBehaviour
{
	public Transform spawnRef;

	public Transform deleteRef;

	public GameObject piecePrefab;

	public List<Transform> scenarioPiece;

	public Vector3 speed;

	public float baseLinePieceDistance;

	public void Update()
	{
	}
}
