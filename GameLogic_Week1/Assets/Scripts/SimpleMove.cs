using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public Transform playerBagContainer;
    public Transform TreasurechestContainer;

    public InsideContainer currentlyIn;

    public enum InsideContainer 
    { 
        PlayerBag,
        Treasurechest
    }
}
