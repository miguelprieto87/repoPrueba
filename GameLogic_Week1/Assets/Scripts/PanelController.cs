using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{

    public TextMeshProUGUI playerName;
    public TextMeshProUGUI playerScore;
    public Image panelControl;

    public Transform playerBag;
    public Transform treasureChest;

    public currentlyInside inside;

    public enum currentlyInside 
    { 
        PlayerBag,
        TreasureChest
    }

}
