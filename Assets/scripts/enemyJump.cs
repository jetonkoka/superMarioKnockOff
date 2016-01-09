using UnityEngine;
using System.Collections;

public class enemyJump : MonoBehaviour {


	public float jumpForce =250f;
	public GameObject deathParticle;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		StartCoroutine(jump());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator jump()
	{
		while(true)
		{
			rb.AddForce(Vector3.up *jumpForce);
			yield return new WaitForSeconds(2);
		}
	}
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
