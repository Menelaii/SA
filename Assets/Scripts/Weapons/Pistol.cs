using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    [SerializeField] private Bullet _pistolBullet;

    public override void Shoot(Transform shootPoint)
    {
        Instantiate(_pistolBullet, shootPoint.position, Quaternion.identity);
    }
}
