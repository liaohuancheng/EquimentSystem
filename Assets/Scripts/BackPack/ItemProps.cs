using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemProps : MonoBehaviour
{
    public Image BgIcon;
    public Image Icon;
    public Text itemCount;
    bool isInBackPack;

    //道具所处状态 在装备栏0，被装备1
    public enum ItemHome
    {
        Items=0,Equiped=1
    }

    Item item;
    public void SetData(Item item)
    {
        this.item = item;
        //0:white 1:cyan 2:blue 3:yellow 4:red
        switch (item.ItemQuality)
        {
            case 0:
                BgIcon.color = Color.white;
                break;
            case 1:
                BgIcon.color = Color.cyan;
                break;
            case 2:
                BgIcon.color = Color.blue;
                break;
            case 3:
                BgIcon.color = Color.yellow;
                break;
            case 4:
                BgIcon.color = Color.red;
                break;
            default:
                BgIcon.color = Color.black;
                break;
        }
        Icon.sprite = Resources.Load<Sprite>("Icons/"+item.ItemIcon);
        if (itemCount != null)
        {
            itemCount.text = item.ItemCount.ToString();
        }
        isInBackPack = true;
    }
    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Right)
        {
            MouseClick();
            
        }
    }

    public void MouseClick()
    {
        if (item.MItemType == Item.ItemType.Potion)
        {
            PotionUse();
        }
        if (item.MItemType == Item.ItemType.Equipment || item.MItemType == Item.ItemType.Weapon) ;
        {
            Equip();
        }
    }

    private void Equip()
    {
        if (item.MItemType == Item.ItemType.Weapon)
        {
            isInBackPack = false;
            fromBackPackToEquip();
        }
    }

    private void fromBackPackToEquip()
    {
        Destroy(gameObject);
        transform.Find("Hellet").GetComponent<ItemProps>().SetData(item);
    }

    private void PotionUse()
    {
        Debug.Log("药水使用");
    }
}
