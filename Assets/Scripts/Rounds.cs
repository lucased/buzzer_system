using UnityEngine;
using System.Collections;

public class Rounds : MonoBehaviour {

	[SerializeField]
	private Round round;
	[SerializeField]
	private int roundPoints;

	public Round getRound() {
		return round;
	}

	public void setRound(Round r) {
		round = r;
	}

	public int getRoundPoints() {
		return roundPoints;
	}



}
