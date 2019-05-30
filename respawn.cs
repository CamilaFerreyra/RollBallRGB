using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

	public Transform respawnVerde;
	public Transform respawnRojo;
	public Transform respawnAzul;
	public Transform respawnJugador;
	private Rigidbody cuerpo; 
	public finish punto;
	
	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("BolaR"))
		{
			//manager.Onred = false;
			other.gameObject.transform.position = respawnRojo.position;
			
			cuerpo= other.gameObject.GetComponent<Rigidbody>();
			cuerpo.velocity = Vector3.zero;
			cuerpo.angularVelocity = Vector3.zero; //rotacion

			punto.restar ();
		}

		if(other.gameObject.CompareTag("BolaV"))
		{
			//manager.Ongreen = false;
			other.gameObject.transform.position = respawnVerde.position;
			cuerpo= other.gameObject.GetComponent<Rigidbody>();
			cuerpo.velocity = Vector3.zero;
			cuerpo.angularVelocity = Vector3.zero; //rotacion

			punto.restar ();
		}

		if(other.gameObject.CompareTag("BolaA"))
		{
			//manager.Onblue = false;
			other.gameObject.transform.position = respawnAzul.position;
			cuerpo= other.gameObject.GetComponent<Rigidbody>();
			cuerpo.velocity = Vector3.zero;
			cuerpo.angularVelocity = Vector3.zero; //rotacion

			punto.restar ();
		}

		if (other.gameObject.tag == "Jugador") 
		{

			other.gameObject.transform.position = respawnJugador.position;
			cuerpo= other.gameObject.GetComponent<Rigidbody>();
			cuerpo.velocity = Vector3.zero;
			cuerpo.angularVelocity = Vector3.zero; //rotacion
		}
	}
}
