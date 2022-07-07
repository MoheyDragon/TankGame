using UnityEngine;

public class TankModel : MonoBehaviour
{
    private TankController tankController;
    public float moveSpeed, rotateSpeed;

    public TankModel(float moveSpeed, float rotateSpeed)
    {
        this.moveSpeed = moveSpeed;
        this.rotateSpeed = rotateSpeed;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
