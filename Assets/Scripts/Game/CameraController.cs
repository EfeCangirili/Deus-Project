using UnityEngine;

public class CameraController : MonoBehaviour {
    public Transform trackedObject;
    public float updateSpeed = 0.125f;
    public Vector3 trackingOffset;
    private Vector3 offset;
    private void Start()
    {
        offset = (Vector3)trackingOffset;
        offset.z = transform.position.z - trackedObject.position.z;
    }
    private void LateUpdate()
    {
        transform.position = trackedObject.position + offset;
    }
}