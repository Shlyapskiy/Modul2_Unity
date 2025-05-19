using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    private Vector3 offset;

    void Start()
    {
        if (target != null)
        {
            Renderer targetRenderer = target.GetComponentInChildren<Renderer>();

            if (targetRenderer != null)
            {
                Vector3 size = targetRenderer.bounds.size;
                float height = size.y;
                float depth = size.z;

                offset = new Vector3(0, height * 2f, -depth * 3f);
            }
            else
            {
                offset = new Vector3(0, 10, -20);
            }
        }
    }

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.LookAt(target);
        }
    }
}
