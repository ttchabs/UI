using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class SpawnerScript : MonoBehaviour
{
    public GameObject potionPrefab;
    public string Potion;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(Potion))
        {
            Instantiate(potionPrefab, transform.position, Quaternion.identity);
            
        }

}
}
