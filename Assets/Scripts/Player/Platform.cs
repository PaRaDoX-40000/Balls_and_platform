using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Platform : Entity
{
    private EntityHealth _entityHealth;

    public EntityHealth EntityHealth => _entityHealth;

    private void Start()
    {
        _entityHealth = GetComponent<EntityHealth>();
    }
}
