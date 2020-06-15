using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody _rigidBody;
    public float _forceVertical;
    public float _torqueHorizontal;

    private float _inputVertical;
    private float _inputHorizontal;

    public void Update()
    {
        _inputVertical = Input.GetAxis("Vertical");
        _inputHorizontal = Input.GetAxis("Horizontal");
    }

    public void FixedUpdate()
    {
        _rigidBody.AddForce(Vector3.forward * _inputVertical * _forceVertical * Time.fixedDeltaTime);
        _rigidBody.AddTorque(Vector3.up * _inputHorizontal * _torqueHorizontal * Time.fixedDeltaTime);
    }

    private void Reset()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
}
