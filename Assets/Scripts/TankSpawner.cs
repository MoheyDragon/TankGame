using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] GameObject TankPrefab;
    void Start()
    {
        Instantiate(TankPrefab, transform.position, Quaternion.identity, transform);
    }
}
