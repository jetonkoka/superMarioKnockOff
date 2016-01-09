using UnityEngine;
using System.Collections;

public class titleScreen : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		if(Input.GetKeyDown(KeyCode.Return))
		{
			Application.LoadLevel(1);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Return))
		{
			Application.LoadLevel(1);
		}
	}
}
