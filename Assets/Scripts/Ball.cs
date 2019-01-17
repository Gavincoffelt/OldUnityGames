using UnityEngine;
using System.Collections;
public class Ball : MonoBehaviour {
public Paddle paddle;
private bool hasStarted = false;
private Vector3 paddletoballvector;
	// Use this for initialization
	void Start () {
	paddle = GameObject.FindObjectOfType<Paddle>();
	paddletoballvector = this.transform.position - paddle.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	if(!hasStarted){
	this.transform.position=paddle.transform.position+paddletoballvector;
	if (Input.GetMouseButtonDown(0)) {
	print ("Mouse Clicked, Launch Ball.");
	hasStarted=true;
	this.rigidbody2D.velocity = new Vector2 (2f,10f);
	}
	}
}
}