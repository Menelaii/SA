using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackState : State
{
    [SerializeField] private float _delay;
    [SerializeField] private Rock _template;
    [SerializeField] private Transform _throwPoint;

    private Animator _animator;
    private float _lastAttackTime;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(_lastAttackTime <= 0)
        {
            Throw();
            _lastAttackTime = _delay;
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Throw()
    {
        _animator.Play("Throw");
        Instantiate(_template, _throwPoint.position, _throwPoint.rotation);
    }
}
