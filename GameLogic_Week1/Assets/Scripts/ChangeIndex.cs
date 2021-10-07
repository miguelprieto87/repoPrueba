using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIndex : MonoBehaviour
{
    public void MoveDown()
    {
        //Assuming that this script exists on the prefab child
        int myIndex = transform.GetSiblingIndex();
        Debug.Log("My index is: " + myIndex);

        //Movr the index lower and sibling index order
        myIndex++;
        transform.SetSiblingIndex(myIndex);
    
    }

    public void MoveUP()
    {
        //Assuming that this script exists on the prefab child
        int myIndex = transform.GetSiblingIndex();
        Debug.Log("My index is: " + myIndex);

        //Movr the index lower and sibling index order
        if (myIndex >0) 
        {
            myIndex--;
            transform.SetSiblingIndex(myIndex);
        }
        

    }

}
