using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    [SerializeField] private CubeInputController cubeInputController;

    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private float horizontalMovementSpeed;
    [SerializeField] private float horizontalLimitValue;


    private float newPositionZ;


    void Update()
    {
        SetCubeForwardMovement();
        SetCubeHorizontalMovement();
    }


    private void SetCubeForwardMovement()
    {
        transform.Translate(Vector3.forward * forwardMovementSpeed * Time.fixedDeltaTime);
    }


    private void SetCubeHorizontalMovement()
    {
        newPositionZ = transform.position.z + cubeInputController.HorizontalValue * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPositionZ = Mathf.Clamp(newPositionZ, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(transform.position.x, transform.position.y, newPositionZ);
    }

}
