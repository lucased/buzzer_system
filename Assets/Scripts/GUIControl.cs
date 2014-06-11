using UnityEngine;
using System.Collections;

public class GUIControl : MonoBehaviour
{

		private Player player;
		private int playerScore;
		private bool pressed;
		private Player player01;
		private Player player02;
		private Player player03;
		private bool curropt1=true; private bool curropt2=false; private bool curropt3=false; private bool curropt4=false;
	
		/*** GET PLAYER GAME OBJECTS ON START ***/
		void Start ()
		{
		
				player01 = GameObject.Find ("Player01").GetComponent<Player> ();
				player02 = GameObject.Find ("Player02").GetComponent<Player> ();
				player03 = GameObject.Find ("Player03").GetComponent<Player> ();
		
		}

		void OnGUI ()
		{
				/*** CORRECT BUTTON ***/

				if (GUI.Button (new Rect (30, 30, 100, 30), "Correct")) {

						if (GameState.Instance.getActivtePlayer () != null) {
								player = GameState.Instance.getActivtePlayer ();
								playerScore = player.getPlayerScore ();
								player.setPlayerScore (playerScore += 5);
								GameState.Instance.resetGameState ();
								
						}
				}
				
				/*** INCORRECT BUTTON ***/

				if (GUI.Button (new Rect (135, 30, 100, 30), "Incorrect")) {

						if (GameState.Instance.getActivtePlayer () != null) {
								player = GameState.Instance.getActivtePlayer ();
								playerScore = player.getPlayerScore ();
								player.setPlayerScore (playerScore -= 5);
								GameState.Instance.resetGameState ();

						}
								
				}

				/*** RESET BUTTON ***/

				if (GUI.Button (new Rect (240, 30, 100, 30), "Reset")) {
						GameState.Instance.resetGameState ();		
				}
					
				/*** PLAYER NAMES & SCORES ***/

				GUI.Label (new Rect (30, 65, 100, 30), player01.getPlayerName ());
				GUI.Label (new Rect (135, 65, 100, 30), player02.getPlayerName ());
				GUI.Label (new Rect (240, 65, 100, 30), player03.getPlayerName ());

				GUI.Label (new Rect (30, 95, 100, 30), player01.getPlayerScore ().ToString ());
				GUI.Label (new Rect (135, 95, 100, 30), player02.getPlayerScore ().ToString ());
				GUI.Label (new Rect (240, 95, 100, 30), player03.getPlayerScore ().ToString ());

				
				/*** ROUND TOGGLE BUTTONS ***/

				if (GUI.Toggle(new Rect( 30, 5, 100, 20), curropt1, "Round 1")) {
						curropt1 = true;
						curropt2 = false;
						curropt3 = false;
						curropt4 = false;
						GameState.Instance.setCurrentRound(Round.ROUND1);
				}
	
				if (GUI.Toggle (new Rect (135, 5, 100, 20), curropt2, new GUIContent ("Round 2"))) {
			
						curropt2 = true;
						curropt1 = false;
						curropt3 = false;
						curropt4 = false;
						GameState.Instance.setCurrentRound(Round.ROUND2);
				}

				if (GUI.Toggle (new Rect (240, 5, 100, 20), curropt3, new GUIContent ("Round 3"))) {
			
						curropt3 = true;
						curropt1 = false;
						curropt2 = false;
						curropt4 = false;
						GameState.Instance.setCurrentRound(Round.ROUND3);
				}

				if (GUI.Toggle (new Rect (345, 5, 100, 20), curropt4, new GUIContent ("Quick Fire"))) {
			
						curropt3 = false;
						curropt1 = false;
						curropt2 = false;
						curropt4 = true;
						GameState.Instance.setCurrentRound(Round.QUICKFIRE);
			
				}
		}
	


}
