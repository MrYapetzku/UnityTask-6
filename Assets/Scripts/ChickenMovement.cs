using UnityEngine;

[RequireComponent(typeof(Transform))]

public class ChickenMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;
    private Chicken _chicken;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _transform.Translate(new Vector3(-_speed * Time.deltaTime, 0, 0));
    }

    private void OnEnable()
    {
        _chicken = gameObject.GetComponentInChildren<Chicken>();
        _chicken.Hit += OnChickenHit;
    }

    private void OnDisable()
    {
        _chicken.Hit -= OnChickenHit;
    }

    private void OnChickenHit()
    {
        _speed = 0f;
    }
}
