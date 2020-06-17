using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler, IDropHandler 
{
    public Draggable.Slot slotType;

    private void Start() {
        
    }
    public void OnPointerEnter(PointerEventData eventData){

    }
     public void OnPointerExit(PointerEventData eventData){
        
    }
    public void OnDrop(PointerEventData eventData){
        Debug.Log(eventData.pointerDrag.name + " was dropped on " + this.gameObject.name);
        Draggable card = eventData.pointerDrag.GetComponent<Draggable>();
        if (card != null && (card.typeOfCard == this.slotType || this.slotType == Draggable.Slot.HAND)){
            card.previousParent = this.transform;
        }
        
    }
}
