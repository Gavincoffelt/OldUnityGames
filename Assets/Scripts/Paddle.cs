using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	Vector3 Paddlepos = new Vector3 (0.5f,this.transform.position.y,0f);
	
	float mouseposinBlocks = (Input.mousePosition.x / Screen.width * 16);
	
	
	
	Paddlepos.x=Mathf.Clamp(mouseposinBlocks,0.5f,15.5f);
	
	this.transform.position= Paddlepos;
	}
}
