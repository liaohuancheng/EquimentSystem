using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Equipment : Item
{

    public int strength;//力量
    public int intellect;//智力
    public int agility;//敏捷
    public int stamina;//体质
    public EquipType equipType;//装备类型

    public enum EquipType
    {
        Unknown = -1,//未知
        armor,//盔甲
        Helmet,//头盔
    }

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
    /// <param name="strength"></param>
    /// <param name="intellect"></param>
    /// <param name="agility"></param>
    /// <param name="stamina"></param>
    /// <param name="equipType"></param>
    /// <param name="itemPrice"></param>
    public Equipment(int itemID, string itemName, string itemDescription, string itemIcon, int itemCount, int itemQuality, int itemOpreation, ItemType mItemType, int strength, int intellect, int agility, int stamina, EquipType equipType, int itemPrice) : base(itemID, itemName, itemDescription, itemIcon, itemCount, itemQuality, itemOpreation, mItemType, itemPrice)
    {
        this.strength = strength;
        this.intellect = intellect;
        this.agility = agility;
        this.stamina = stamina;
        this.equipType = equipType;
    }

    public override string ToString()
    {
        string str = "";
        str += " ID:" + ItemID;
        str += " Name:" + ItemName;
        str += " Desc:" + ItemDescription;
        str += " Icon:" + ItemIcon;
        str += " Count：" + ItemCount;
        str += " Quality：" + ItemQuality;
        str += " Opreation：" + ItemOperation;
        str += " Type：" + MItemType;
        str += " strength：" + strength;
        str += " intellect：" + intellect;
        str += " agility：" + agility;
        str += " stamina：" + stamina;
        str += " equipType：" + equipType;
        return str;
    }
}

