using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    private bool m_check;

    public bool Check { get => m_check; set => m_check = value; }

    public void LaunchCoroutine()
    {
       // if(Check == false)
            //StartCoroutine(CheckMovementHello());
    }

    /*IEnumerator CheckMovementHello()
    {
        yield return WaitForSeconds(2);
    }*/
}
