using UnityEngine;
using System.Collections;

public class movingPlatform : MonoBehaviour {

	public Rigidbody rb;
	private float pushForce = 20f;
	private float positionOfPlayer;
	// Use this for initialization
	void Start () 
	{
		positionOfPlayer = rb.transform.position.x;
		StartCoroutine(jump());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator jump()
	{
		//this cycles the enemy left and right .01f units on the x axis relative to its initial starting position
		while(true)
		{
			if(rb.transform.position.x > positionOfPlayer -.001f)
			{
				rb.AddForce(Vector3.left * pushForce);
				yield return new WaitForSeconds(2);

			}
			else if(rb.transform.position.x < positionOfPlayer + .001f)
			{
				rb.AddForce(Vector3.right * pushForce);
				yield return new WaitForSeconds(2);

			}

		}
	}
}
