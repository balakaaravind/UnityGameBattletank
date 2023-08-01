//Tank View Script


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movement;

    private float rotation;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -5f);


    }


    void Update()
    {
        Movement();

        if (movement != 0)
            tankController.Move(movement,tankController.GetTankModel().movementSpeed);

         
        if (rotation != 0)
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
    }
    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
    
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }


    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
