using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomComponent : MonoBehaviour
{
    private Renderer renderer;
    public void Start()
    {
        //caching the renderer
        renderer = GetComponent<Renderer>();
    }
    // Method invoked via SendMessage
    public void ReceiveMessage()
    {
        Debug.Log("CustomMethod called via SendMessage.");
        if (renderer != null)
        {
            renderer.material.color = Color.yellow;
        }

    }
    public void DoSomething()
    {
       
        if (renderer != null)
        {
            renderer.material.color = Color.green;
            Debug.Log("Changed color of first Renderer in otherObject.");
        }
    }
}
