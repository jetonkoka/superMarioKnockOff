using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "mario")
		{
			Application.LoadLevel(3);
			//Application.LoadLevel(2);
			//score.theCurrentScore++;
		}
	}
}
