using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackPackDetail : MonoBehaviour
{
    public Text Name;
    public Text Description;
    public Button BtnSell;
    public Button BtnEquip;

    /// <summary>
    /// 将道具的名字，信息显示到ui层
    /// 根据道具的类型显示可操作的按钮
    /// </summary>
    /// <param name="item"></param>
    public void SetData(Item item)
    {
        Name.text = item.ItemName;
        Description.text = item.ItemDescription;
        BtnSell.gameObject.SetActive(true);
        BtnEquip.gameObject.SetActive(item.MItemType == Item.ItemType.Equipment|| item.MItemType == Item.ItemType.Weapon);
    }
}
