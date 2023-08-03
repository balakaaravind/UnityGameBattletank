//Tank Spawner Script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
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

    void Start()
    {
        CreateTank();
    }



    private void CreateTank()
    {
        //Default greentank
        TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
        TankController tankController = new TankController(tankModel, tankView);

    }
}
