using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePointer : MonoBehaviour
{
    public RectTransform rawImageRectTransform; // Assign your RawImage's RectTransform in the Inspector.

    private Canvas canvas; // The canvas that contains your RawImage.

    private void Start()
    {
        // Get a reference to the canvas that contains the RawImage.
        canvas = GetComponentInParent<Canvas>();
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }

        // Check if the RawImage RectTransform is assigned.
        if (rawImageRectTransform == null)
        {
            Debug.LogError("RawImage RectTransform not assigned.");
            return;
        }

        // Get the mouse position in screen space.
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position from screen space to canvas space.
        Vector2 canvasPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, mousePosition, canvas.worldCamera, out canvasPosition);

        // Set the RawImage's position to the converted canvas position.
        rawImageRectTransform.anchoredPosition = canvasPosition;
    }
}
