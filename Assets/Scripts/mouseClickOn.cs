using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClickOn : MonoBehaviour
{
    
    Ray ray;
    RaycastHit hit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object has a ClickableItem script attached
                receiveClick receiveclick = hit.collider.GetComponent<receiveClick>();
                if (receiveclick != null)
                {
                    // Handle the click event for the clicked item
                    receiveclick.OnMouseDown();
                }
            }
        }
    } 
}
