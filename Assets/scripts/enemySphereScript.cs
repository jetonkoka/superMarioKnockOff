using UnityEngine;
using System.Collections;

public class enemySphereScript : MonoBehaviour {

	public float pushForce =150f;
	public Rigidbody rb;
	private int counter = 0;
	private float positionOfPlayer;
	public GameObject deathParticle;
	// Use this for initialization
	void Start () {
		StartCoroutine(jump());
		positionOfPlayer = rb.position.x;
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator jump()
	{
		//this cycles the enemy left and right .01f units on the x axis relative to its initial starting position
		while(true)
		{
			if(rb.position.x > positionOfPlayer -.01f)
			{
				rb.AddForce(Vector3.left *pushForce);
				yield return new WaitForSeconds(2);

			}
			else if(rb.position.x < positionOfPlayer + .01f)
			{
				rb.AddForce(Vector3.right *pushForce);
				yield return new WaitForSeconds(2);

			}

		}
	}
	//kills mario if he touches the enemy
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "mario")
		{
			Destroy(Instantiate(deathParticle, transform.position,transform.rotation) as GameObject, 5);
			Destroy(col.gameObject);
			//Application.LoadLevel(2);
			//score.theCurrentScore++;
		}
	}
}
