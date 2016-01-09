using UnityEngine;
using System.Collections;


public class characterDie : MonoBehaviour 
{
	public GameObject theFloor;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void onTriggerEnter(Collider collision)
	{
		if(collision.gameObject == theFloor)
		{
			Destroy(collision.gameObject);
		}
	}
}
