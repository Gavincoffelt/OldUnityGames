﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
public Sprite[] hitSprites;
private int timesHit;
private LevelManager levelManager;

	// Use this for initialization
	void Start () {
	timesHit = 0;
	levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D collision) {
	bool isBreakable = (this.tag == "Breakable");
	if (isBreakable) {
		Handlehits();
	}
	}
	void Handlehits() {
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits){Destroy (gameObject);
		} else {
			LoadSprites();
		}
	}
	void LoadSprites() {
	int spriteIndex = timesHit -1;
	this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
}
