using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Rock : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _impulse;
    [SerializeField] private float _impulseSpread;

    private void Start()
    {
        _impulse += Random.Range(-_impulseSpread, _impulseSpread);
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * _impulse, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
            player.TakeDamage(_damage);

        if (collision.TryGetComponent<Enemy>(out Enemy enemy) == false && collision.TryGetComponent<Rock>(out Rock rock) == false)
            Destroy(gameObject);
    }
}
