//Tank MOdel script
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movementSpeed;
    public float rotationSpeed;
    public TankModel(float _movement,float _rotation)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
    }


    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
