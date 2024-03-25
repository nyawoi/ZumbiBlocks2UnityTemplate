using UnityEngine;

public class TranslationController : MonoBehaviour
{
	public static TranslationController instance;

	public KeycodeTranslation keyCode;

	public Language genericExpression;

	public Language[] languages;

	[Header("Runtime")]
	public bool working;

	public int curLangIndex;

	[Header("Test Spreadsheet")]
	public TSVLoader tsvLoader;

	public int GetLanguageIndex(string langShortName)
	{
		return 0;
	}

	public void SetLanguage(string langShortName)
	{
	}

	public void SetLanguage(int index)
	{
	}

	public string GetTranslatedTag(string s)
	{
		return null;
	}

	public string GetTranslated(string s)
	{
		return null;
	}

	public void Init()
	{
	}

	public void LoadTSVLocalization()
	{
	}

	public void DumpLocalization(Language l)
	{
	}
}
