using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLiveController : MonoBehaviour, ICubeDestroer, ICubeCreater
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Transform _cubeSpawnPosition;
    private void Start()
    {
        CreateNewCube();
    }
    public void CreateNewCube()
    {
        if (GameObject.FindGameObjectsWithTag("Cube").Length == 0)
        {
            var cube = Instantiate(_cubePrefab, _cubeSpawnPosition.localPosition, new Quaternion());
        }
    }
    public void DestroyCube(GameObject cub) => Destroy(cub);
}
