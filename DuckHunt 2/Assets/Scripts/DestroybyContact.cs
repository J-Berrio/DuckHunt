using UnityEngine;
using System.Collections;

public class DestroybyContact : MonoBehaviour
{
	public int scoreValue;
	private GameController gameController;
	//private RestartScript restartScript;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) 
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter(Collider other) 

	{
		if (other.tag == "Boundary") 
		{
			return;
		}

		if (other.tag == "Player") 
		{
			gameController.GameOver ();
			//RestartScript.PlayerDies ();
		}

		gameController.AddScore (scoreValue);
		Destroy(other.gameObject);
		Destroy(gameObject);

	}
}
