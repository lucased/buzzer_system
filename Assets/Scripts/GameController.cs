using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

		public Player player01;
		public Player player02;
		public Player player03;

		// Use this for initialization
		void Start ()
		{

				player01 = GameObject.Find ("Player01").GetComponent<Player> ();
				player02 = GameObject.Find ("Player02").GetComponent<Player> ();
				player03 = GameObject.Find ("Player03").GetComponent<Player> ();
	
		}
	
		// Update is called once per frame
		void Update () {

			
		}
}
