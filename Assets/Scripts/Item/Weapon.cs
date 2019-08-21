using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Weapon : Item
{
    int damage;//伤害

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="itemID"></param>
    /// <param name="itemName"></param>
    /// <param name="itemDescription"></param>
    /// <param name="itemIcon"></param>
    /// <param name="itemCount"></param>
    /// <param name="itemQuality"></param>
    /// <param name="itemOpreation"></param>
    /// <param name="mItemType"></param>
    /// <param name="damage"></param>
    /// <param name="itemPrice"></param>
    public Weapon(int itemID, string itemName, string itemDescription, string itemIcon, int itemCount, int itemQuality, int itemOpreation, ItemType mItemType,int damage,int itemPrice) : base(itemID, itemName, itemDescription, itemIcon, itemCount, itemQuality, itemOpreation, mItemType,itemPrice)
    {
        this.damage = damage;
    }

    public override string ToString()
    {
        string str = "";
        str += " ID：" + ItemID;
        str += " Name：" + ItemName;
        str += " Desc：" + ItemDescription;
        str += " Icon：" + ItemIcon;
        str += " Count：" + ItemCount;
        str += " Quality：" + ItemQuality;
        str += " Opreation：" + ItemOperation;
        str += " Type：" + MItemType;
        str += " damage：" + damage;

        return str;
    }
}

