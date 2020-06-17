using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform previousParent = null;

    public enum Slot { //The different slots available on the Play Area
        ATTACK1,
        ATTACK2,
        ATTACK3,
        DEF1,
        DEF2,
        SUPPORT,
        HAND
    }

    public Slot typeOfCard = Slot.ATTACK1; 

    public void OnBeginDrag(PointerEventData eventData){
        this.previousParent = this.transform.parent;
        this.transform.SetParent(this.transform.root);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData){
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData){
        
        this.transform.SetParent(this.previousParent);
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }
}
