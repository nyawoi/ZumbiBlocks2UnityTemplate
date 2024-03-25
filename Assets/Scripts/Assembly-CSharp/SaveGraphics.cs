using System;

[Serializable]
public class SaveGraphics
{
	public int resW;

	public int resH;

	public int fullScreen;

	public int vsync;

	public int msaa;

	public int fpsLimit;

	public bool showfps;

	public int drawDist;

	public int animQual;

	public int shadEnable;

	public int shadDist;

	public int shadRes;

	public int softShad;

	public int ppAO;

	public int ppBloom;

	public int ppGrading;

	public int ppDOF;

	public int ppBlur;

	public void Reset()
	{
	}
}
