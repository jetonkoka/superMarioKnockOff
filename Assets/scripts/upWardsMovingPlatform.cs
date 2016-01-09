using UnityEngine;
using System.Collections;

public class upWardsMovingPlatform : MonoBehaviour {

	public Rigidbody rb;
	private float pushForce = 100000;
	private float positionOfPlayer;
	// Use this for initialization
	void Start () 
	{
		positionOfPlayer = rb.transform.position.y;
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
			if(rb.transform.position.y > positionOfPlayer -2f)
			{
				rb.AddForce(Vector3.down * pushForce);
				yield return new WaitForSeconds(2);

			}
			else if(rb.transform.position.y < positionOfPlayer + 2f)
			{
				rb.AddForce(Vector3.up * pushForce);
				yield return new WaitForSeconds(2);

			}

		}
	}
}
