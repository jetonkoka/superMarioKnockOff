using UnityEngine;
using System.Collections;

public class changeLightColor : MonoBehaviour {
	public Light light;
	// Use this for initialization
	void Start () 
	{
		light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Color rand = new Color(Random.value, Random.value,Random.value);
		light.color = rand;
		//WaitForSeconds(2);
}
}