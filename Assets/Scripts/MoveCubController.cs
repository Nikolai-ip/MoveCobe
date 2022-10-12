using System.Collections;
using UnityEngine;

public class MoveCubController : MonoBehaviour
{
    private IGetTime _inputTime;
    private IGetSpeed _inputSpeed;
    private Vector3 _direction = Vector3.right;
    private Transform _cubeTr;
    private ICubeCreater _cubeCreater;
    private float _liveTime;
    private float _speed;

    private void Start()
    {
        _cubeTr = GetComponent<Transform>();
        _inputTime = GetComponent<IGetTime>();
        _inputSpeed = GetComponent<IGetSpeed>();
        _cubeCreater = FindObjectOfType<CubeLiveController>();
    }
    public void StartMove()
    {
        _liveTime = _inputTime.Time;
        _speed = _inputSpeed.Speed;
        StartCoroutine("Move");
    }

    private IEnumerator Move()
    {
        float time = 0;
        while (time < _liveTime)
        {
            _cubeTr.position += _direction * _speed * Time.deltaTime;
            time += Time.deltaTime;
            yield return null;
        }
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        _cubeCreater?.CreateNewCube();
    }
}