using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public Transform cam;
    public Transform rot;
    public float speed = 4f;
    public float testMod = 45f;

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

        Vector3 tempCameraPosition = new Vector3(
            cameraPosition.x,
            cameraPosition.z,
            0f);

        Vector3 tempPlayerPosition = new Vector3(
            playerPosition.x,
            playerPosition.z,
            0f);

        float ValX = tempPlayerPosition.x - tempCameraPosition.x;
        float ValY = tempPlayerPosition.y - tempCameraPosition.y;

        if (ValX < 0) {
            ValX 
        }
        else if (ValY < 0) {

        }

        float angle = Mathf.Atan(ValY / ValX) * Mathf.Rad2Deg;


        

        rb.velocity = new Vector3(0f, 0f, 0f);
        Vector3 tempVelocity = rb.velocity;

        rot.rotation = Quaternion.Euler(0f, angle, 0f);
        Debug.Log(angle);


        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
            //Get camera and player position
            //Vector3 cameraPosition = cam.position;
            //Vector3 playerPosition = transform.position;

            ////get differrence for movement calculation
            //float ValX = playerPosition.x - cameraPosition.x;
            //float ValZ = playerPosition.z - cameraPosition.z;

            //rb.velocity = new Vector3(0f, 0f, 0f);
            //Vector3 tempVelocity = rb.velocity;
            //float angle = Mathf.Atan(ValX / ValZ * Mathf.Deg2Rad);

            //rot.rotation = Quaternion.Euler(0f, angle, 0f);
            //Debug.Log(angle);

            //if (Input.GetAxis("Vertical") > 0) {
            //    tempVelocity.x += ValX;
            //    tempVelocity.z += ValZ;
            //} else if (Input.GetAxis("Vertical") < 0) {
            //    tempVelocity.x += ValX * -1;
            //    tempVelocity.z += ValZ * -1;
            //}

            //if (Input.GetAxis("Horizontal") != 0) {
            //    float angle = Mathf.Atan(ValX / ValZ * Mathf.Deg2Rad);
            //    if (Input.GetAxis("Horizontal") > 0)
            //    {
            //        tempVelocity.x += Mathf.Sin(angle) * Mathf.Rad2Deg;
            //        tempVelocity.z += Mathf.Cos(angle) * Mathf.Rad2Deg;
            //    }
            //    else if (Input.GetAxis("Horizontal") < 0)
            //    {
            //        tempVelocity.x += Mathf.Sin(angle) * Mathf.Rad2Deg * -1;
            //        tempVelocity.z += Mathf.Cos(angle) * Mathf.Rad2Deg * -1;
            //    }
            //}

            //rb.velocity = tempVelocity.normalized * speed;
        }
    }

    public static float CalculateAngle(Vector3 from, Vector3 to)
    {
        return Quaternion.FromToRotation(Vector3.up, to - from).eulerAngles.z;

    }

}

