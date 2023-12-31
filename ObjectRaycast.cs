using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRaycast : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material highlightMaterial;
    //[SerializeField] private Material defaultMaterial;

    private Transform _selection;

    private void Update()
    {
        if (Input.GetButtonDown("Fire2")) { 
         /*  if (_selection != null)
        {
            
                var selectionRenderer = _selection.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial;
                _selection = null;
            
        }*/
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                //if (Input.GetButtonDown("Fire2"))

                    if (selection.CompareTag(selectableTag))
                    {
                        var selectionRenderer = selection.GetComponent<Renderer>();


                        if (selectionRenderer != null)
                        {
                            selectionRenderer.material = highlightMaterial;
                        }
                        _selection = selection;

                    }
            }
        }
    }
}
