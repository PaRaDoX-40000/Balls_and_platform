using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeMoney : MonoBehaviour
{
    [SerializeField] private СurrencyСontainer _сurrencyСontainer;
    [SerializeField] private MoneyPanelUI moneyPanelUI;

    public void AddGold(int quantity)
    {      
        _сurrencyСontainer.AddGold(quantity);
        moneyPanelUI.SetMoneyText(_сurrencyСontainer.Gold);
    }
    private void Start()
    {
        moneyPanelUI.SetMoneyText(_сurrencyСontainer.Gold);
    }
}
