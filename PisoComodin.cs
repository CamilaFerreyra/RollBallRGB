using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoComodin : MonoBehaviour {

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
			manager.sumar ();
			manager.Ongreen = true;
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if(other.gameObject.CompareTag("BolaR"))
		{
			manager.sumar ();
			manager.Onred = true;
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if(other.gameObject.CompareTag("BolaA"))
		{
			manager.sumar ();
			manager.Onblue = true;
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		
	}
}