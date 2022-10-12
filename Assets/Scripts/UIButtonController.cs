using UnityEngine;

public class UIButtonController : MonoBehaviour
{
    public void StartMoveCube()
    {
        var cube = FindObjectOfType<MoveCubController>();
        cube.StartMove();
    }
}