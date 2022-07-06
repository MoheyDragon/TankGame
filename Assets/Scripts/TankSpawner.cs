using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] TankView tankView;
    void Start()
    {
        CreatTank();
    }
    private void CreatTank()
    {
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankModel, tankView);
    }
}
