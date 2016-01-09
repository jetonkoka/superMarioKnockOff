using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class score : MonoBehaviour {

	public static float theCurrentScore = 0;
	public float timer = 0;
	public TextMesh txt;
	// Use this for initialization
	void Start () 
	{
		timer = 0;
		timer = Mathf.Round(timer * 100f)/100f;
		txt.text = "Score: " + theCurrentScore.ToString() + "\nTime: " + timer.ToString(); 	
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;
		timer = Mathf.Round(timer * 100f)/100f;
		txt.text = "Score: " + theCurrentScore.ToString() + "\nTime: " + timer.ToString(); 	
	}
}
