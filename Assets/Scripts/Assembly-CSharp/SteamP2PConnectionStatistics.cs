public class SteamP2PConnectionStatistics
{
	private float RecentStartTime { get; set; }

	public double SentBytes { get; private set; }

	private double RecentlySentBytes { get; set; }

	public float UploadRate { get; private set; }

	public double ReceivedBytes { get; set; }

	private double RecentlyReceivedBytes { get; set; }

	public float DownloadRate { get; private set; }

	public void Sent(double byteAmount)
	{
	}

	public void Received(double byteAmount)
	{
	}

	public void CalculateBandRates()
	{
	}
}
