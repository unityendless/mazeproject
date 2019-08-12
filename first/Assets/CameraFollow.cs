using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraOffset;
    public float smoothspeed = 0.125f;
    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = player.position +  cameraOffset;
        Vector3 desiredPos = player.position + cameraOffset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPos, smoothspeed);
        transform.position = smoothPosition;

    }
}
