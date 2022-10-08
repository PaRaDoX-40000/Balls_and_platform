using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : Entity
{
    private EntityHealth _entityHealth;
    private BallSticking _ballSticking;

    public EntityHealth EntityHealth => _entityHealth;
    public BallSticking BallSticking => _ballSticking;

    private void Start()
    {
        _entityHealth = GetComponent<EntityHealth>();
        _ballSticking = GetComponent<BallSticking>();

    }
}
