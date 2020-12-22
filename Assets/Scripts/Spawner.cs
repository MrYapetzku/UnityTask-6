using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField][Range(0.5f, 5f)] private float _spawnTimeDelta;
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private GameObject _chicken;

    private Transform[] _points;
    private float _currentTime = 0f;

    private void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }
    }
    
    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _spawnTimeDelta)
        {
            Instantiate(_chicken, _points[Random.Range(0, _spawnPoints.childCount)].position, Quaternion.identity);

            _currentTime = 0f;
        }        
    }
}
