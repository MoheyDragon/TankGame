using UnityEngine;

public class TankModel : MonoBehaviour
{
    private TankController tankController;
    public float moveSpeed, rotateSpeed;
    public TankType tankType;
    public Material color;

    public TankModel(Tank tank)
    {
        this.moveSpeed = tank.MovementSpeed;
        this.rotateSpeed = tank.RotationSpeed;
        this.tankType = tank.tankType;
        this.color = tank.color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
