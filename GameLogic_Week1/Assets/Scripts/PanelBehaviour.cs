using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBehaviour : MonoBehaviour
{
    public PanelController panelController;

    public void MoveMe() 
    {
        //

        switch (panelController.inside)
        {
            case PanelController.currentlyInside.PlayerBag: 
                transform.SetParent(null);
                break;
            case PanelController.currentlyInside.TreasureChest:
                transform.SetParent(panelController.playerBag);
                break;
            default:
                break;
        }
    }
}
