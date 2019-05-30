using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionBolaAzul : MonoBehaviour {

	public finish punto;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "BolaV")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            punto.puntos = 0;
        }
		if (other.gameObject.tag == "BolaR")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            punto.puntos = 0;
        }
    }
}
