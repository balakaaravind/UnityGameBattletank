using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpwaner tankSpawner;
    public GameObject joystickUI;

    public void BlueTankSelected()
    {
        joystickUI.SetActive(true);
        tankSpawner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);


    }

    public void GreenTankSelected()
    {
        joystickUI.SetActive(true);
        tankSpawner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }


    public void RedTankSelected()
    {
        joystickUI.SetActive(true);
        tankSpawner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }

}
