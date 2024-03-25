using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GraphicsMenu : MonoBehaviour
{
	[Header("References")]
	public ResolutionSelector resolution;

	public DisplaySelector display;

	public SettingsSelector fullScreen;

	public SettingsSelector vsync;

	public SettingsSelector antiAlias;

	public SettingsSelector shadowEnable;

	public SettingsSelector shadowResolution;

	public SettingsSelector shadowDistance;

	public SettingsSelector softShadow;

	public SettingsSelector animationDetail;

	public SettingsSelector drawDistance;

	public SettingsSelector ambientOcclusion;

	public SettingsSelector bloom;

	public SettingsSelector colorGrading;

	public SettingsSelector depthOfField;

	public SettingsSelector motionBlur;

	public Slider fpsLimitSlider;

	public TMP_Text fpsLimitText;

	[Header("Settings")]
	public SaveGraphics graphics;

	public int GetFPSLimitFromSlider()
	{
		return 0;
	}

	private void PullData()
	{
	}

	public void ApplyToUI()
	{
	}

	public void UpdateFPSText()
	{
	}

	public void CheckDataIntegrity()
	{
	}

	public void ReturnFromGraphics(BaseMenu returnMenu)
	{
	}

	public void ApplyGraphics(bool setResolution = true)
	{
	}

	public void FlipShowFPS()
	{
	}

	public void SetFPSLimit(int fps)
	{
	}

	private void SetDrawDistance()
	{
	}

	private void SetShadow()
	{
	}

	private void SetAntiAliasing()
	{
	}
}
