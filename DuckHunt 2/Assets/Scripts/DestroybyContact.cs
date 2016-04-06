using UnityEngine;
using System.Collections;

public class DestroybyContact : MonoBehaviour
{
	public int scoreValue;
	public GameController gameController;

	void OnTriggerEnter(Collider other) 

	{
		if (other.tag == "Boundary") 
		{
			return;
		}

		gameController.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
