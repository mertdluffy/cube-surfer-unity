using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInputController : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalValue;

    public float HorizontalValue
    {
        get { return horizontalValue; }
    }



    void Update()
    {
        HandleCubeHorizontalInput();
    }



    private void HandleCubeHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalValue = 0;
        }
    }
}
