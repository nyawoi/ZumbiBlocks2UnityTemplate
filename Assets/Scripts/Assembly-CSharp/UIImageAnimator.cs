using UnityEngine;
using UnityEngine.UI;

public class UIImageAnimator : MonoBehaviour
{
	public Image targetImage;

	public Sprite[] frame;

	public float speed;

	[Header("Runtime")]
	public int index;

	public float timer;

	private void Update()
	{
	}
}
