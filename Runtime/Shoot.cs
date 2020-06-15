using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform _spawnPosition;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab, _spawnPosition.position, transform.rotation);
        }
    }
}
