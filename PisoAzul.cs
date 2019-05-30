﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoAzul : MonoBehaviour {

	public Transform respawnVerde;
	public Transform respawnRojo;
	public Transform respawnJugador;
	private Rigidbody cuerpo; 
	public finish manager;

	//public respawn puntitos;

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("Jugador"))
		{
			other.gameObject.transform.position = respawnJugador.position;
			cuerpo= other.gameObject.GetComponent<Rigidbody>();
			cuerpo.velocity = Vector3.zero;
			cuerpo.angularVelocity = Vector3.zero; //rotacion
		}
		if(other.gameObject.CompareTag("BolaV"))
		{
			//manager.Ongreen = false;
			other.gameObject.transform.position = respawnVerde.position;
			cuerpo= other.gameObject.GetComponent<Rigidbody>();
			cuerpo.velocity = Vector3.zero;
			cuerpo.angularVelocity = Vector3.zero; //rotacion
	//		puntitos.punto.restar ();
			manager.restar ();
		}

		if(other.gameObject.CompareTag("BolaR"))
		{
			//manager.Onred = false;
			other.gameObject.transform.position = respawnRojo.position;
			cuerpo= other.gameObject.GetComponent<Rigidbody>();
			cuerpo.velocity = Vector3.zero;
			cuerpo.angularVelocity = Vector3.zero; //rotacion
	//		puntitos.punto.restar ();
			manager.restar ();
		}

		if(other.gameObject.CompareTag("BolaA"))
		{
			manager.sumar ();
			manager.Onblue = true;
			Destroy(other.gameObject);
		}
		
	}
}
