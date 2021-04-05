using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Weapon
{
    [SerializeField] private AxeBullet _AxeBullet;
    [SerializeField] private float _shootPointYDifference;

    public override void Shoot(Transform shootPoint)
    {
        Instantiate(_AxeBullet, new Vector2(shootPoint.position.x, shootPoint.position.y + _shootPointYDifference), Quaternion.identity);
    }
}
