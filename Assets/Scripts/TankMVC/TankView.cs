using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement, Rotation;
    [SerializeField] private Rigidbody rb;
    private void Start()
    {
        GameObject camera = Camera.main.gameObject;
        camera.transform.SetParent(transform);
        camera.transform.position = new Vector3(0, 3, -4);
    }
    private void Update()
    {
        HandelMovement();
        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().moveSpeed);
        if (Rotation != 0)
            tankController.Rotate(Rotation, tankController.GetTankModel().rotateSpeed);
    }
    private void  HandelMovement()
    {
        movement = Input.GetAxis("Vertical");
        Rotation = Input.GetAxis("Horizontal");
    }
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
    public Rigidbody GetRigidbody() => rb;
}
