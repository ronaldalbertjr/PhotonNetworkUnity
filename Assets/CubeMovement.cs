using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour
{
    [SerializeField]
    float speedMovement, speedRotation;
    float w, h;
    Vector3 auxVelocity;
    Rigidbody rb;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	void Update ()
    {
        w = Input.GetAxis("Horizontal");
        h = Input.GetAxis("Vertical");
        MovementUpdate(h, speedMovement);
        RotationUpdate(w, speedRotation);
	}

    void MovementUpdate(float w, float speed)
    {
        auxVelocity = transform.forward * w * speed * Time.deltaTime;
        auxVelocity.y = rb.velocity.y;
        rb.velocity = auxVelocity;
    }

    void RotationUpdate(float h, float speed)
    {
        transform.eulerAngles += transform.up * h * speed * Time.deltaTime;
    }
}

