//Tank Spawner Script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TankSpwaner : MonoBehaviour, IPointerUpHandler
{
    [System.Serializable]
    public class Tank
    {

        public float movementSpeed;

        public float rotationSpeed;

        public TankTypes tankType;
        public Material color;
    }

    public List<Tank> tankList;


    public TankView tankView;

    TankController tankController;

    private float movement;

    private float rotation;

    public bool Pressed;

    protected Joystick Joystick;
    public void OnUpButtonPressed()
    {
        Debug.Log("UpCalled");
        movement = 0.2f;
    }

    public void OnDownButtonPressed()
    {
        Debug.Log("DownCalled");
        movement = -0.2f;
    }

    public void OnLeftButtonPressed()
    {
        Debug.Log("LeftCalled");
        rotation = -0.2f;
    }

    public void OnRightButtonPressed()
    {
        Debug.Log("RightCalled");
        rotation = 0.2f;
    }

    public void OnButtonReleased()
    {
        movement = 0f;
        rotation = 0f;
    }



    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
    void Start()
    {
    }

    private void FixedUpdate()
    {
        if (tankController != null)
        {
            tankController.Move(Joystick.Vertical, tankController.GetTankModel().movementSpeed);
            tankController.Rotate(Joystick.Horizontal, tankController.GetTankModel().rotationSpeed);
        }
    }


    public void CreateTank(TankTypes tankType)
    {

        TankModel tankModel1;


        if (tankType == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
            tankModel1 = tankModel;
            Debug.Log("clicked on blue");
        }
        else if (tankType == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
            tankModel1 = tankModel;
            Debug.Log("clicked on Green");
        }
        else if (tankType == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
            tankModel1 = tankModel;
        }
        else
        {
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
            tankModel1 = tankModel;
        }

        Joystick = FindAnyObjectByType<Joystick>();
        tankController = new TankController(tankModel1, tankView);

    }
}
