using UnityEngine;
using System.Collections;

public class Unicow : MonoBehaviour
{
    public float forwardSpeed = 10.0f;
    public float backwardSpeed = 2.0f;
    public float strafeSpeed = 7.0f;
    public float turnRate = 80.0f;
    public float jumpSpeed = 100.0f;

    public Transform lowestGroundObject;
    public Transform respawnPosition;

    // Use this for initialization
    void Start()
    {

    }

    public void Respawn()
    {
        transform.position = respawnPosition.position;
        transform.rotation = respawnPosition.rotation;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * forwardSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * backwardSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * strafeSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * strafeSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(0.0f, -turnRate * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0.0f, turnRate * Time.deltaTime, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += transform.up * jumpSpeed * Time.deltaTime;
        }
    }
}