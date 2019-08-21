using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{

    public enum ItemType
    {
        Unknown = -1,//未知
        Weapon,
        Equipment,//装备
        Potion,//药水
    }
    public int ItemID;//id，主键
    public string ItemName;//名字
    public string ItemDescription;//描述
    public string ItemIcon;//图标
    public int ItemCount;//道具数量
    public int ItemQuality;//品质
    public int ItemOperation;//道具可进行什么操作
    public ItemType MItemType = ItemType.Unknown;//道具类型
    public int ItemPrice;//道具价格

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="itemID"></param>
    /// <param name="itemName"></param>
    /// <param name="itemDescription"></param>
    /// <param name="itemIcon"></param>
    /// <param name="itemBgIcon"></param>
    /// <param name="itemCount"></param>
    /// <param name="itemQuality">0:white 1:cyan 2:blue 3:orange 4:red</param>
    /// <param name="itemOpreation"></param>
    /// <param name="mItemType">-1:unknow 0:Weapon 1:equip 2:Potion</param>
    public Item(int itemID, string itemName, string itemDescription, string itemIcon,  int itemCount, int itemQuality, int itemOpreation, ItemType mItemType,int itemPrice)
    {
        ItemID = itemID;
        ItemName = itemName;
        ItemDescription = itemDescription;
        ItemIcon = itemIcon;
        ItemCount = itemCount;
        ItemQuality = itemQuality;
        ItemOperation = itemOpreation;
        MItemType = mItemType;
        ItemPrice = itemPrice;
        //Debug.LogError(ItemID + " " + ItemName + " " + ItemDescription + " " + ItemIcon + " "  + ItemCount + " " + ItemQuality + " " + ItemOperation + " " +
        //        MItemType + " ");
    }

}
