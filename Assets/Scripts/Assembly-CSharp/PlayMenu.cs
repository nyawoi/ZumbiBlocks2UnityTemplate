using UnityEngine;

public class PlayMenu : BaseMenu
{
	[Header("Multiplayer buttons")]
	[SerializeField]
	private MosaicButton hostButton;

	[SerializeField]
	private MosaicButton connectButton;

	public override void OnEnterMenu()
	{
	}
}
