using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public Transform followTarget;

	private void LateUpdate() {
		Vector3 targetPos = followTarget.position;

		targetPos.z = transform.position.z;

		transform.position = targetPos;
	}
}
