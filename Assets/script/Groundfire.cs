﻿using UnityEngine;
using System.Collections;

public class Groundfire : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _verticalSpeed;
	private float _horizontalDrift;
	//private bulletFiring enemy;
	public GameObject tank;


	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform>();
		// Reset the bullets` Sprite to the Top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this._horizontalDrift, this._verticalSpeed);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.y >= 200) {
			this.Reset ();
		}
	}

	public void Reset() {
		this._verticalSpeed=-1f;
		this._horizontalDrift = 3f;

		this._transform.position = this.tank.transform.position;
	}
}
