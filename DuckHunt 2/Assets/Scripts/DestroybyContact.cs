using UnityEngine;
using System.Collections;

public class DestroybyContact : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) 

	{
		if (other.tag == "Boundary") 
		{
			return;
		}

		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
