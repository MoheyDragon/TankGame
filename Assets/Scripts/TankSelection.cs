using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
    public void SelectTank(int index)
    {
        tankSpawner.CreatTank(index);
        gameObject.SetActive(false);
    }
}
