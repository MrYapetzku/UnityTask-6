using System.Collections;
using UnityEngine;

public class ChickensDie : MonoBehaviour
{
    [SerializeField] [Range(0f, 3f)] private float _delayTimeToDestroy;

    private Chicken _chicken;

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
        Destroy(gameObject, _delayTimeToDestroy);
    }
}
