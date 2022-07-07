using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;
    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();
        tankModel.SetTankController(this);
        tankView.SetTankController(this);
    }
    public void Move(float movement,float speed)
    {
        rb.velocity = tankView.transform.forward * movement * speed;
    }
    public void Rotate(float rotation, float speed)
    {
        Vector3 rotateVector = new Vector3(0, rotation * speed, 0);
        Quaternion deltaRotation = Quaternion.Euler(rotateVector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
    public TankModel GetTankModel() => tankModel;
}
