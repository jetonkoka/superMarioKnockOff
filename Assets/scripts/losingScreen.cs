using UnityEngine;
using System.Collections;

public class losingScreen : MonoBehaviour {
	public TextMesh txt;
	// Use this for initialization
	void Start () 
	{
		txt.text = "Score: " + score.theCurrentScore.ToString();	
	}

	// Update is called once per frame
	void Update () 
	{
		txt.text = "Score: " + score.theCurrentScore.ToString();	
	}
}
