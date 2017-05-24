using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathzone : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D collider)
	{
		rabbittosha rabit = collider.GetComponent<rabbittosha>();
		if (rabit != null)
		{
			levelcontroller.current.onRabitDeath(rabit);
		}
	}
}
