using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bad Practice
[System.Serializable]
public class Item
{
    public string name;
    public string value;
    public Color myColor;
}


public class PanelPopulater : MonoBehaviour
{
    public GameObject prefabPlayerScore;
    public Transform myContainer;
    public int quantity;
    public string namingConvention = "Player";
    public Color panelColor;

    //To be able to use the class Item that is also serialized
    [SerializeField]
    public Item myItem;


    private void Start()
    {
        //PopulateContent();
    }

    void PopulateContent()
    {
        Debug.Log("PopulateContent");

        for (int i=0; i < quantity; i++)
        {
            int randoScore = Random.Range(0,100);
            //int randomColor = Random.Range(0,panels);
            myDataCreation( (namingConvention + (i+1)) , randoScore.ToString(), panelColor );

        }                
    }

    public void PickUpItem()
    {
        myDataCreation(myItem.name, myItem.value, myItem.myColor);
    
    }

    void myDataCreation(string name, string score, Color myColor)
    {
        GameObject myPrefab = Instantiate(prefabPlayerScore, myContainer);
        PanelController myController = myPrefab.GetComponent<PanelController>();

        myController.playerName.text = name;
        myController.playerScore.text = score;
        myController.panelControl.color = myColor;
    }

}
