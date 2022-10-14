using System;
using System.Collections;
using UnityEngine;

public class MoveCubController : MonoBehaviour
{
    private IGetTime _inputTime;
    private IGetSpeed _inputSpeed;
    private Vector3 _direction = Vector3.right;
    private Transform _cubeTr;
    public event Action<GameObject> destroyCube = delegate { };
    private float _liveTime;
    private float speed;

    private void Start()
    {
        _cubeTr = GetComponent<Transform>();
        _inputTime = GetComponent<IGetTime>();
        _inputSpeed = GetComponent<IGetSpeed>();
        destroyCube += FindObjectOfType<CubeLiveController>().DestroyCube;
    }
    public void StartMove()
    {
        _liveTime = _inputTime.Time;
        speed = _inputSpeed.Speed;
        StartCoroutine("Move");
    }

    private IEnumerator Move()
    {
        float time = 0;
        while (time < _liveTime)
        {
            _cubeTr.position += _direction * speed * Time.deltaTime;
            time += Time.deltaTime;
            yield return null;
        }
        destroyCube(gameObject);
    }
}