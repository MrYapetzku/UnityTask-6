using UnityEngine;
using UnityEngine.Events;

public class Chicken : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;

    public event UnityAction Hit
    {
        add => _hit.AddListener(value);
        remove => _hit.RemoveListener(value);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
            _hit?.Invoke();
    }
}
