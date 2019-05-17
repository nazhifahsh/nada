using UnityEngine;
using System.Collections;

// animasi awan

public class awanGerak : MonoBehaviour {

	public float speed;
	
	void Start () {
	
	}
	void Update () {
		Vector3 position = transform.position;
		position.x += speed;
		if (position.x > 12f)
			position.x = -12f;
		transform.position = position;
	}
}
