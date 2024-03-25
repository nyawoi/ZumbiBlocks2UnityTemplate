using System.Collections.Generic;

public class PlayerControlEnabler
{
	private enum State
	{
		Inactive = 0,
		Syncing = 1,
		Active = 2
	}

	private PlayerMain targetPlayer;

	private State state;

	private int initialSyncFrame;

	private List<IntVec2> expectedCells;

	private bool IsInitialFrame => false;

	public bool Enabled => false;

	public bool Syncing => false;

	public PlayerControlEnabler(PlayerMain targetPlayer)
	{
	}

	public void OnRequestedCell(IntVec2 cell)
	{
	}

	private void AddRequestedCell(IntVec2 cell)
	{
	}

	public void VerifyEnabledState()
	{
	}
}
