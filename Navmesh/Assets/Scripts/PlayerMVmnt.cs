using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMVmnt : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Rigidbody rb;
    public float MaxJumps;
    float jumps;
    // Start is called before the first frame update
    void Start()
    {
        jumps = MaxJumps;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(Quaternion.Euler(0, 90, 0).eulerAngles);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(Quaternion.Euler(0, -90, 0).eulerAngles);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumps > 0)
            {
                rb.AddForce(transform.up * speed, ForceMode.Impulse);
                jumps--;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            jumps = MaxJumps;
        }
    }
}
