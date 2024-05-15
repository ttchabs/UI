using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableObject : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler
{
    private Transform parentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
       Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
    }
    
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
