//Tank Controller Script
using UnityEngine;

public class TankController
{
    // Start is called before the first frame update
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankModel _tankModel , TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = _tankView;

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);

    }
}
