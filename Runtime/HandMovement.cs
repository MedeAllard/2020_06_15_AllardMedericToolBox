using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HandMovement : MonoBehaviour
{
    public Transform m_head;
    public Transform m_hand;

    public bool leftRightBoolean;
    public bool previousLeftRightBoolean;
    public int counter;
    public float timeCountdown;

    public UnityEvent onStartWaving;
    public UnityEvent onEndWaving;

    private bool angleMin = false;

    private bool m_check;

    public bool Check { get => m_check; set => m_check = value; }

    private void Update()
    {
        if(m_check)
        {
            Vector3 localDirection = (m_head.InverseTransformPoint(m_hand.position)).normalized;
            leftRightBoolean = localDirection.x > 0;
            if (previousLeftRightBoolean != leftRightBoolean)
            {
                counter++;
                timeCountdown = 0.5f;
                if (counter == 3)
                {
                    onStartWaving.Invoke();
                }
            }
            if(timeCountdown > 0)
            {
                timeCountdown -= Time.deltaTime;
            }
            if(timeCountdown < 0)
            {
                onEndWaving.Invoke();
                counter = 0;
                timeCountdown = 0;
            }
            previousLeftRightBoolean = leftRightBoolean;
        }
    }
}
