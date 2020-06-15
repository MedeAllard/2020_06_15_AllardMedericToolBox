using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float timeDestroy;
    void Start()
    {
        Destroy(this, timeDestroy);
    }
}
