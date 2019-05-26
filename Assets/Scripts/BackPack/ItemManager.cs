using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using LitJson;


public class ItemManager
{

    /// <summary>
    /// 单例模式
    /// </summary>
    private static ItemManager instance;

    public static ItemManager Instance
    {
        get
        {
            if (instance == null) instance = new ItemManager();
            return instance;
        }

        set
        {
            instance = value;
        }
    }

    private JsonData _itemData;
    public List<Item> Items = new List<Item>();

    /// <summary>
    /// 加载json
    /// </summary>
    public void LoadItemConfigData()
    {
        _itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Config/Items.json", Encoding.GetEncoding("GB2312")));
        this.DecodeJson();
    }


    /// <summary>
    /// 解析json
    /// </summary>
    private void DecodeJson()
    {
        for (int i = 0; i < _itemData.Count; i++)
        {
            int itemId = (int)_itemData[i]["ItemID"];
            string itemName = _itemData[i]["ItemName"].ToString();
            string itemDesc = _itemData[i]["ItemDescription"].ToString();
            string itemIcon = _itemData[i]["ItemIcon"].ToString();
            int itemCount = (int)_itemData[i]["ItemCount"];
            int itemQuality = (int)_itemData[i]["ItemQuality"];
            int itemOperation = (int)_itemData[i]["ItemOperation"];
            Item.ItemType itemType = (Item.ItemType)System.Enum.Parse(typeof(Item.ItemType), _itemData[i]["ItemType"].ToString());
            Item item = null;
            switch (itemType)
            {
                case Item.ItemType.Unknown:
                    break;
                case Item.ItemType.Weapon:
                    int damage = (int)_itemData[i]["damage"];
                    item = new Weapon(itemId, itemName, itemDesc, itemIcon, itemCount, itemQuality, itemOperation, itemType, damage);
                    break;
                case Item.ItemType.Equipment:
                    int strength = (int)_itemData[i]["strength"];
                    int intellect = (int)_itemData[i]["intellect"];
                    int agility = (int)_itemData[i]["agility"];
                    int stamina = (int)_itemData[i]["stamina"];
                    Equipment.EquipType equipType = (Equipment.EquipType)System.Enum.Parse(typeof(Item.ItemType), _itemData[i]["equipType"].ToString()); 
                    item = new Equipment(itemId, itemName, itemDesc, itemIcon, itemCount, itemQuality, itemOperation, itemType, strength, intellect, agility, stamina, equipType);
                    break;
                case Item.ItemType.Potion:
                    int hp = (int)_itemData[i]["hp"];
                    int mp = (int)_itemData[i]["mp"];
                    item = new Potion(itemId, itemName, itemDesc, itemIcon, itemCount, itemQuality, itemOperation, itemType, hp, mp);
                    break;

            }


            Debug.Log(item.ToString());

            
            Items.Add(item);
        }
    }

}
