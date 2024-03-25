using TMPro;

public class ServerSettingsMenu : BaseMenu
{
	public GenericPromptMenu prompt;

	public TMP_InputField portField;

	public TMP_InputField passwordField;

	public ZBSlider playersSlider;

	private bool useDefaultPort;

	public void StartServer()
	{
	}

	public void BackToServerCreation()
	{
	}

	public override void OnEnterMenu()
	{
	}
}
