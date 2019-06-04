using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        for (int i = 0; i < 50; i++)
            for (int j = 0; j < 20; j++)
            {
                Instantiate(prefab, new Vector3(i, j, 0), Quaternion.identity);
            }
    }
}