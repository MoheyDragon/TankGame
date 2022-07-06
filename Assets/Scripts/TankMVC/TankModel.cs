using UnityEngine;

public class TankModel : MonoBehaviour
{
    private TankController tankController;
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
