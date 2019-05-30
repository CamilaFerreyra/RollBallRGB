using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionBolaVerde : MonoBehaviour {
	public finish punto;
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "BolaR")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            punto.puntos = 0;
        }
	}
}
