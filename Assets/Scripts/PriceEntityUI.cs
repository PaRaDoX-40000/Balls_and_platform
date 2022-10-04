using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PriceEntityUI : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private Button _button;
    [SerializeField] private TMP_Text _buttonText;
    [SerializeField] private TMP_Text _price;

   



    public void Init(PriceEntity priceEntity,bool selected)
    {
        if (priceEntity.Purchased == false)
        {
            _buttonText.text = "Купить";
            _price.gameObject.SetActive(true);
            _price.text = priceEntity.Price.ToString();
            _button.interactable = true;
        }
        else
        {
            if (selected == false)
            {
                _buttonText.text = "Выбрать";
                _button.interactable = true;
            }
            else
            {
                _buttonText.text = "Выбран";
                _button.interactable = false;
            }
           
            _price.gameObject.SetActive(false);                
        }
        _button.onClick.RemoveAllListeners();
        _button.onClick.AddListener(priceEntity.TryBuyEntityVoid);
        _image.sprite = priceEntity.Entity.Icon;
        _title.text = priceEntity.Entity.EntityName;
        _description.text = priceEntity.Entity.Description;
    }
}
