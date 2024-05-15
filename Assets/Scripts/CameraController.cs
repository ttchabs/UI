using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public float moveDistance = 10f;
    public float speed = 10f;
    public Button chestButton;
    public float moveSpeed;

    private void Start()
    {
        Button btn = chestButton.GetComponent<Button>();
        btn.onClick.AddListener(moveCamera);
    }

    void moveCamera()
    {
        Vector3 moveDirection = new Vector3(moveDistance, 0f, 0f);
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
    
    
    
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Camera.main.transform.Translate(1,1,1);
        }
    }
}


