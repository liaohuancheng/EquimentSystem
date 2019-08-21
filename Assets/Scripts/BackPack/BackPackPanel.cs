using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BackPackPanel : MonoBehaviour
{
    public ScrollRect ItemScrollRect;
    public Transform ItemTemp;
    public BackPackDetail BackPackDetail;
    private List<Item> itemList = null;
    private List<GameObject> itemOBJList = new List<GameObject>();

    public Tweener PnlInfoTween;
    public Tweener PnlBackpackTween;
    public Transform PnlInfoOBJ;
    public Transform PnlInfoFrom;
    public Transform PnlInfoTo;

    public Transform PnlBackpackOBJ;
    public Transform PnlBackpackFrom;  
    public Transform PnlBackpackTo;


    void Awake()
    {
        ItemManager.Instance.LoadItemConfigData();
        this.itemList = ItemManager.Instance.Items;

        PnlInfoOBJ.localPosition = PnlInfoFrom.localPosition;
        PnlBackpackOBJ.localPosition = PnlBackpackFrom.localPosition;
    }


    void Start()
    {

        PnlInfoTween = PnlInfoOBJ.DOLocalMoveX(PnlInfoTo.localPosition.x, 0.5f);
        PnlBackpackTween = PnlBackpackOBJ.DOLocalMoveX(PnlBackpackTo.localPosition.x, 0.5f);

        PnlInfoTween.SetAutoKill(false);
        PnlBackpackTween.SetAutoKill(false);

        PnlInfoTween.Pause();
    }

    private void OnEnable()
    {
        CreateItem();
    }

    /// <summary>
    /// 创建具体的道具
    /// </summary>
    /// <returns>GameObject</returns>
    private GameObject CreateConcreteItem()
    {
        GameObject go = GameObject.Instantiate(ItemTemp.gameObject, ItemScrollRect.content);
        return go;
    }

    /// <summary>
    /// 创建所有的道具以及相应的隐藏操作
    /// </summary>
    /// <param name="itemType"></param>
    private void CreateItem(Item.ItemType itemType = Item.ItemType.Unknown)
    {

        for (int i=0; i<itemList.Count; i++)
        {
            GameObject go = null;
            if (itemList[i].MItemType != itemType && itemType != Item.ItemType.Unknown)
            {
                go = itemOBJList[i];
                go.SetActive(false);
                continue;
            }

            if (i < itemOBJList.Count)
            {
                go = itemOBJList[i];
            }
            else
            {
                go = CreateConcreteItem();
                itemOBJList.Add(go);
            }
            go.SetActive(true);
            var item = itemList[i];
            ItemProps info = go.GetComponent<ItemProps>();
            Button btn = go.GetComponent<Button>();
            btn.onClick.AddListener(() =>
            {

                BackPackDetail.SetData(item);
                PnlInfoTween.PlayForward();

            });
            if(info == null)
            {
                go.SetActive(false);
                continue;
            }
            info.SetData(this .itemList[i]);
        }

        
    }

    /// <summary>
    /// 显示所有的道具
    /// </summary>
    /// <param name="t"></param>
    public void AllItemClick(Toggle t)
    {
        if (t.isOn)
        {
            CreateItem();
        }
        else
        {
            return;
        }
    }
    
    /// <summary>
    /// 显示装备
    /// </summary>
    /// <param name="t"></param>
    public void EquipItemClick(Toggle t)
    {
        if (t.isOn)
        {
            CreateItem(Item.ItemType.Equipment);
        }
        else
        {
            return;
        }
    }

    /// <summary>
    /// 显示药水
    /// </summary>
    /// <param name="t"></param>
    public void PotionItemClick(Toggle t)
    {
        if (t.isOn)
        {
            CreateItem(Item.ItemType.Potion);
        }
        else
        {
            return;
        }
    }

    /// <summary>
    /// 显示武器
    /// </summary>
    /// <param name="t"></param>
    public void WeaponItemClick(Toggle t)
    {
        if (t.isOn)
        {
            CreateItem(Item.ItemType.Weapon);
        }
        else
        {
            return;
        }
    }

}
