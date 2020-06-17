using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardHover : MonoBehaviour
{
    static int heightOffset = 5;
    private void OnMouseOver(){
        Debug.Log("HOVER");
        this.transform.position += Vector3.up * heightOffset;
    }

    private void OnMouseExit(){
        this.transform.position += Vector3.down * heightOffset;
    }
}
