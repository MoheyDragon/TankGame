using UnityEditor;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] TankView tankView;
    public List<Tank> tankList;
    [Header("Enter index of the Tank You want to spawn")]
    public int SpawnedTankIndex;
    void Start()
    {
        CreatTank();
    }
    private void CreatTank()
    {
        TankModel tankModel = new TankModel(tankList[SpawnedTankIndex]);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
[System.Serializable]
public class Tank
{
    public float MovementSpeed, RotationSpeed;
    public TankType tankType;
    public Material color;
}
