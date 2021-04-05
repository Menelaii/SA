using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeBullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _killEnemies;

    private int _hits = 0;
    private float _bulletX;

    private void Update()
    {
        _bulletX -= _speed * Time.deltaTime;
        transform.position = new Vector2(_bulletX, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            Destroy(enemy.gameObject);
            _hits++;
            
            if (_hits >= _killEnemies)
                Destroy(gameObject);
        }
    }
}
