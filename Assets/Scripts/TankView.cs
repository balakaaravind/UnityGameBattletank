//Tank View Script


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movement;

    private float rotation;

    public Rigidbody rb;

    public MeshRenderer[] childs;

    //Joystick 

    public void OnUpButtonPressed()
    {
        Debug.Log("UpCalled");
        movement = 1f;
    }

    public void OnDownButtonPressed()
    {
        Debug.Log("DownCalled");
        movement = -1f;
    }

    public void OnLeftButtonPressed()
    {
        Debug.Log("LeftCalled");
        rotation = -1f;
    }

    public void OnRightButtonPressed()
    {
        Debug.Log("RightCalled");
        rotation = 1f;
    }

    public void OnButtonReleased()
    {
        movement = 0f;
        rotation = 0f;
    }


    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -7f);


    }


    //void Update()
    //{
    //    Movement();

    //    if (movement != 0)
    //        tankController.Move(movement, tankController.GetTankModel().movementSpeed);


    //    if (rotation != 0)
    //        tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
    //}

    void Update()
    {
        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);

        if (rotation != 0)
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
    }


    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        Debug.Log("Vertical" + movement);

        rotation = Input.GetAxis("Horizontal");
        Debug.Log("Horizontal" + rotation);
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }


    public Rigidbody GetRigidbody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        for (int i = 0; i < childs.Length; i++)
        {
            childs[i].material = color;
        }
    }

   

}
