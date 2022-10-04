using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    [SerializeField] private List<PriceEntity> _platformPrefabs;
    private int _selectedPlatform=0;
    [SerializeField] private List<PriceEntity> _bollPrefabs;
    private int _selectedBoll=0;
    [SerializeField] private StartSpawnSystem _startSpawnSystem;
    [SerializeField] private SelectPlayerUI _selectPlayerUI;
    private int _displayStatus=0;


    private void Start()
    {
        foreach(PriceEntity priceEntity in _platformPrefabs)
        {
            priceEntity.EntityBought += UpdatePanel;
            priceEntity.EntitySelected += ChooseEntity;
        }
        foreach (PriceEntity priceEntity in _bollPrefabs)
        {
            priceEntity.EntityBought += UpdatePanel;
            priceEntity.EntitySelected += ChooseEntity;
        }
    }

    private void ChooseEntity(PriceEntity entity)
    {
        if (_displayStatus == 0)
        {
            ChoosePlatform(entity.Entity);
            _selectedPlatform = _platformPrefabs.IndexOf(entity);
            UpdatePanel();
            
        }
        else
        {
            ChooseBoll(entity.Entity);
            _selectedBoll = _bollPrefabs.IndexOf(entity);
            UpdatePanel();          
        }
    }


    public void ChoosePlatform(Entity entity)
    {
        _startSpawnSystem.ChangePlatform(entity);
    }
    public void ChooseBoll(Entity entity)
    {
        _startSpawnSystem.ChangeBoll(entity);
    }


    private void UpdatePanel()
    {
       
        if (_displayStatus == 0)
        {
            ShowePlatform();
        }
        else
        {
            ShoweBoll();
        }
    }

    public void ShowePlatform()
    {
        _selectPlayerUI.ShoweEntity(_platformPrefabs, _selectedPlatform);
        _displayStatus = 0;
        
    }
    public void ShoweBoll()
    {
        _selectPlayerUI.ShoweEntity(_bollPrefabs, _selectedBoll);
        _displayStatus = 1;
    }


}
