using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

		public string playerName;
		public int playerScore;
		public State playerState;
		public PlayerPos playerPos;

		void Start ()
		{
				WhichPlayer (playerPos);
		}

		void HandleOnPlayerBuzz ()
		{
				print (playerName + ": Buzzed");
		}

		private void WhichPlayer (PlayerPos player)
		{

				switch (player) {

				case PlayerPos.PLAYER01:
						EventManager.OnPlayer01Buzz += HandleOnPlayerBuzz;
						break;

				case PlayerPos.PLAYER02:
						EventManager.OnPlayer02Buzz += HandleOnPlayerBuzz;
						break;

				case PlayerPos.PLAYER03:
						EventManager.OnPlayer03Buzz += HandleOnPlayerBuzz;
						break;
				}

		}

		public void resetState ()
		{
				playerState = State.IDLE;
		}

		public State getPlayerState ()
		{
				return playerState;
		}

		public void setPlayerState (State state)
		{
				playerState = state;
		}

		public int getPlayerScore ()
		{
				return playerScore;
		}

		public void setPlayerScore (int score)
		{
				playerScore = score;
		}

		public string getPlayerName ()
		{
				return playerName;
		}
	
		public void setPlayerScore (string name)
		{
				playerName = name;
		}
	
}
