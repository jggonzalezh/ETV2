using UnityEngine;
using System.Collections;

public class adminMenu : MonoBehaviour {

    public Transform currentMount;
    public static float speedFactor = 0.1f;
    public static float zoomFactor = 24f;
    public Camera camara;
    private Vector3 lastPosition;

	// Use this for initialization
	void Start () {
        lastPosition= transform.position;
	}

    // Update is called once per frame
    void Update() {
        transform.position = Vector3.Lerp(transform.position, currentMount.position, speedFactor);
        transform.rotation = Quaternion.Slerp(transform.rotation, currentMount.rotation, speedFactor);

        float velocidad = Vector3.Magnitude(transform.position - lastPosition);
        camara.fieldOfView = 60 + velocidad + zoomFactor;

        lastPosition = transform.position;

	}

    public void setMount(Transform newMount)
    {
        currentMount = newMount;
    }
    
}
