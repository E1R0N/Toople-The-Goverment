﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Principal : MonoBehaviour {
	public Vector2 sensibility;
	private Transform cam;
	public float bulletforce = 200;//fuerza del proyectil
	public float shotrate=0.5f; //tiempo entre diparo
	private float shotratetime = 0;
	// Use this for initialization
	void Start () {
		Debug.Log ("Game started");
		sensibility.x = 5;
		sensibility.y = 5;
		cam = transform.Find ("Main Camera");
		Cursor.lockState = CursorLockMode.Locked; //cursor no sale del juego

	}
	
	// Update is called once per frame
	void Update () {
		float hor = Input.GetAxis ("Mouse X");
		float ver = Input.GetAxis ("Mouse Y");
		//mover camara y personaje en X
		if (Input.GetMouseButtonDown (0)) {
			
		}
		if (hor != 0) {
			transform.Rotate (Vector3.up*hor*sensibility.x);
		}
		if (ver != 0) {//rotacion de la camara en Y 
			//cam.Rotate (Vector3.left*ver*sensibility.y);
			float angle=(cam.localEulerAngles.x-ver*sensibility.y+360)%360; //variable de angulo a partir del de la camara.
			if(angle>180){angle-=360;}
			angle=Mathf.Clamp(angle,-80,80);//limita el angulo de la camara
			cam.localEulerAngles = Vector3.right * angle;
		}
	}
}