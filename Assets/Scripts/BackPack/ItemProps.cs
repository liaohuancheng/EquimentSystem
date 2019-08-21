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


    Item item;
    public void SetData(Item item)
    {
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
    }
    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Right)
        {

        }
    }
}
