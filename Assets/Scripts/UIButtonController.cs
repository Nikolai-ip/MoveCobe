using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonController : MonoBehaviour
{
    public void StartMoveCube()
    {
        var cube = GameObject.FindGameObjectWithTag("Cube");
        cube.GetComponent<MoveCubController>().StartMove();
    }
}
