using UnityEngine;
using System.Collections;


public class jumpingMotion : MonoBehaviour {
	public Rigidbody mario;
	public GameObject objectCameraWillMoveWith;
	public GameObject coin;
	float jumpForce =150f;
	float moveRight = 2f;
	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 	
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			
			//transform.position += new Vector3(0f,1.5f,0f);

				mario.AddForce(Vector3.up * jumpForce);	


		}	
		if(Input.GetKey(KeyCode.RightArrow))
		{
			//mario.AddForce(Vector3.right * moveRight);
			if(mario.transform.position.x < 52f)
			{
				transform.position += new Vector3(.09f,0f, 0f);
			}

			if(objectCameraWillMoveWith.transform.position.x < 54f)
			{
				objectCameraWillMoveWith.transform.position += new Vector3(.09f,0f, 0f);
			}

		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			if(mario.transform.position.x > -7f)
			{
				transform.position += new Vector3(-.09f,0f, 0f);
			}
			if(objectCameraWillMoveWith.transform.position.x > 10f)
			{
				objectCameraWillMoveWith.transform.position += new Vector3(-.09f,0f, 0f);
			}
		}

	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "coin")
		{
			Destroy(col.gameObject);
			score.theCurrentScore++;
		}
	}
}
