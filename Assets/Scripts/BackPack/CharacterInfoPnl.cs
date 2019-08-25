using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfoPnl : MonoBehaviour
{
    private Text hpText;
    private Text mpText;
    private Text strText;
    private Text agiText;
    private Text intText;
    private Text staText;
    // Start is called before the first frame update
    void Awake()
    {
        hpText = transform.Find("Canvas/PnlCharacterInfo/PnlHp/Text").GetComponent<Text>();
        mpText = transform.Find("Canvas/PnlCharacterInfo/PnlMp/Text").GetComponent<Text>();
        strText = transform.Find("Canvas/PnlCharacterInfo/PnlStrength/Text").GetComponent<Text>();
        agiText = transform.Find("Canvas/PnlCharacterInfo/PnlAgility/Text").GetComponent<Text>();
        intText = transform.Find("Canvas/PnlCharacterInfo/PnlStamina/Text").GetComponent<Text>();
        staText = transform.Find("Canvas/PnlCharacterInfo/PnlIntellect/Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Start()
    {
        UPdatePanel();
    }

    void UPdatePanel()
    {
        hpText.text = Player.Instance.hp.ToString();
        mpText.text = Player.Instance.mp.ToString();
        strText.text = Player.Instance.strength.ToString();
        agiText.text = Player.Instance.agility.ToString();
        intText.text = Player.Instance.intellect.ToString();
        staText.text = Player.Instance.stamina.ToString();
    }
}
