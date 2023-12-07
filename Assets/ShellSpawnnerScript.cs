using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellSpawnnerScript : MonoBehaviour
{
    public Transform position;
    public GameObject shell;
    public Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        shellMovement();

    }

    void shellMovement()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(shell, transform.position, Quaternion.identity);
            rb.velocity = new Vector3(0f, 0f, 10f);
        }
    }
}
