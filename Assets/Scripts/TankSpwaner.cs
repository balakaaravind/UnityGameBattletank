//Tank Spawner Script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    public TankView tankView;
   
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(30, 20);
        TankController tankController = new TankController(tankModel, tankView);

    }
}
