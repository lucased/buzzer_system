using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour
{

		public delegate void PlayerBuzz ();

		public static event PlayerBuzz OnPlayer01Buzz;
		public static event PlayerBuzz OnPlayer02Buzz;
		public static event PlayerBuzz OnPlayer03Buzz;

		public Player player;

		void Update ()
		{	

				if (GameState.Instance.getGameState () == State.IDLE) {
		
						if (Input.GetKeyDown ("a")) {
					
								if (OnPlayer01Buzz != null) {
										OnPlayer01Buzz ();	
										GameState.Instance.setGameState (State.BUZZED);
										player = GameObject.Find ("Player01").GetComponent<Player> ();
										player.playerState = State.BUZZED;
										GameState.Instance.setActivePlayer (player);
										
								}
						
						}
		
						if (Input.GetKeyDown ("s")) {
			
								if (OnPlayer02Buzz != null) {
										OnPlayer02Buzz ();		
										GameState.Instance.setGameState (State.BUZZED);
										player = GameObject.Find ("Player02").GetComponent<Player> ();
										player.playerState = State.BUZZED;
										GameState.Instance.setActivePlayer (player);;
								}
						}
		
						if (Input.GetKeyDown ("d")) {
			
								if (OnPlayer03Buzz != null) {
										OnPlayer03Buzz ();
										GameState.Instance.setGameState (State.BUZZED);
										player = GameObject.Find ("Player03").GetComponent<Player> ();
										player.playerState = State.BUZZED;
										GameState.Instance.setActivePlayer (player);
								}
						}
				}

				if (Input.GetKeyDown ("r")) {
						GameState.Instance.resetGameState ();
				}
		}
	

}
