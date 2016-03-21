using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerMove1 : MonoBehaviour 
{
	private Rigidbody rb;
	private float nextFire;

	public float speed;
	public GameObject shot;
	public Transform ShotsSpawn;
	public float fireRate;

	public Boundary boundary;
	

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, ShotsSpawn.position, ShotsSpawn.rotation);
		}
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		rb.position = new Vector3 
		(
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax), 
			0, 
			Mathf.Clamp (rb.position.z, boundary.zMin, boundary.zMax)
		);
	}
}