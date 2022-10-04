using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Сurrency Сontainer", menuName = "Сurrency Сontainer", order = 100)]
public class СurrencyСontainer : ScriptableObject
{
    [SerializeField] private int _gold;
    public int Gold => _gold;
    
    public bool TryRemoveGold(int quantity)
    {
        if(_gold- quantity < 0)
        {
            return false;
        }
        else
        {
            _gold -= quantity;
            return true;
        }
    }
    public void AddGold(int quantity)
    {
        _gold += quantity;
       

    }
}
