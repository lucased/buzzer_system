using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour
{

		private static GameState instance;
		[SerializeField]
		private Round
				currentRound;
		[SerializeField]
		private int
				roundPoints;
		[SerializeField]
		private Player
				activePlayer;
		[SerializeField]
		private State
				gameState;

		public static GameState Instance {
				get {
						if (instance == null) {
								instance = new GameObject ("GameState").AddComponent<GameState> ();
								DontDestroyOnLoad (instance.gameObject);
						}

						return instance;
				}
		}

		public void OnApplicationQuit ()
		{
				instance = null;
		}

		void Start ()
		{
				currentRound = Round.ROUND1;
				gameState = State.IDLE;
		}

		public int RoundPoints { 
				get {
						return roundPoints;
				} 
				set {
						roundPoints = value;
				} 
		}

		public Round getCurrentRound ()
		{
				return currentRound;
		}

		public void setCurrentRound (Round round)
		{
				currentRound = round;
		}

		public State getGameState ()
		{
				return gameState;
		}

		public void setGameState (State state)
		{
				gameState = state;
		}

		public Player getActivtePlayer ()
		{
				return activePlayer;	
		}

		public void setActivePlayer (Player player)
		{
				activePlayer = player;
		}

		public void resetGameState ()
		{		
				Round round = GameState.Instance.getCurrentRound ();
				
				if (round == Round.QUICKFIRE) {
						GameState.Instance.setGameState (State.IDLE);
						activePlayer.setPlayerState (State.LOCKED);
				} else {
						GameState.Instance.setGameState (State.IDLE);
						if (activePlayer != null) {
								activePlayer.resetState ();
						}
				}

				

				GameState.Instance.setActivePlayer (null);
				
		}

}
