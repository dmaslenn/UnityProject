using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbitcamera : MonoBehaviour {

	public rabbittosha rabbit;

	void Update () {
		Transform rabbit_transform = rabbit.transform;
		Transform rabbitcamera_transform = this.transform;

		Vector3 rabbit_position = rabbit_transform.position;
		Vector3 rabbitcamera_position = rabbitcamera_transform.position;

		rabbitcamera_position.x = rabbit_position.x;
		rabbitcamera_position.y = rabbit_position.y;

		rabbitcamera_transform.position = rabbitcamera_position;
	}
}
