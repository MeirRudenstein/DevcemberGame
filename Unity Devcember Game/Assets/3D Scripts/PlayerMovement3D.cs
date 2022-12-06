using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public Transform cam;
    public Transform rot;
    public float speed = 4f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = cam.position;
        Vector3 playerPosition = transform.position;

        float ValX = playerPosition.x - cameraPosition.x;
        float ValY = playerPosition.z - cameraPosition.z;

        float angle = Mathf.Atan2(ValX, ValY) * Mathf.Rad2Deg; //Returns the angle between -180 and 180.
        angle += 90;

        rot.rotation = Quaternion.Euler(0f, angle, 0f);
        Debug.Log(angle);




        rb.velocity = new Vector3(0f, 0f, 0f);
        Vector3 tempVelocity = rb.velocity;

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
            if (Input.GetAxis("Horizontal") != 0) {
                tempVelocity += rot.transform.forward * Input.GetAxis("Horizontal");
            }

            if (Input.GetAxis("Vertical") != 0) {
                tempVelocity += rot.transform.right * Input.GetAxis("Vertical") * -1;
            }

            rb.velocity = tempVelocity.normalized * speed;
        }
    }

}

