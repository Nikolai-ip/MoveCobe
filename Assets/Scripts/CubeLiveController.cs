using UnityEngine;

public class CubeLiveController : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Transform _cubeSpawnPosition;

    private void Start()
    {
        CreateNewCube();
    }

    public void CreateNewCube()
    {
        var cube = Instantiate(_cubePrefab, _cubeSpawnPosition.localPosition, new Quaternion());
    }

    public void DestroyCube(GameObject cub)
    {
        Destroy(cub);
        CreateNewCube();
    }
}