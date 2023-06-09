using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour,IBeginDragHandler,IDragHandler, IEndDragHandler
{
    [HideInInspector] public Transform parentAfterDrag;
    public Image image;

    public void OnBeginDrag(PointerEventData eventData)
    {
       image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    { 
        transform.position = Input.mousePosition;
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
      image.raycastTarget = true;
        transform.SetParent(parentAfterDrag);
    }

  
}
