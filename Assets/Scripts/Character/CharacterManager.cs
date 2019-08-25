using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    /// <summary>
    /// 单例模式
    /// </summary>
    private static CharacterManager instance;

    public static CharacterManager Instance
    {
        get
        {
            if (instance == null) instance = new CharacterManager();
            return instance;
        }

        set
        {
            instance = value;
        }
    }

    private JsonData _characterData;
    //public List<Item> Items = new List<Item>();
    
    /// <summary>
    /// 加载json
    /// </summary>
    public void LoadItemConfigData()
    {
        _characterData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Config/Character.json", Encoding.GetEncoding("GB2312")));
        this.DecodeJson();
    }


    /// <summary>
    /// 解析json
    /// </summary>
    private void DecodeJson()
    {
        string name = _characterData[0]["Name"].ToString();
        string description = _characterData[0]["Description"].ToString();
        int strength = (int)_characterData[0]["Strength"];
        int intellect = (int)_characterData[0]["Intellect"];
        int agility = (int)_characterData[0]["Agility"];
        int stamina = (int)_characterData[0]["Stamina"];
        int hp = (int)_characterData[0]["Hp"];
        int mp = (int)_characterData[0]["Mp"];
        
    }
}
