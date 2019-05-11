using UnityEngine;

public class CameraController : MonoBehaviour {
	
	public Vector3 cameraPosition = Vector3.zero;
	public Transform target;
    public bool ready_ = false;
  
	
	void FixedUpdate() {
        if (ready_)
        {
            cameraPosition = new Vector3(
                Mathf.SmoothStep(transform.position.x, target.transform.position.x, 0.2f),
                Mathf.SmoothStep(transform.position.y, target.transform.position.y, 0));
        }
	}
	
	void LateUpdate() {
		
		transform.position = cameraPosition + Vector3.forward * -10;
		
	}
	
}