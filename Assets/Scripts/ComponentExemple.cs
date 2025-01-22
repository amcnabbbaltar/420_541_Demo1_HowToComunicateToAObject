using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // References to other components
    public GameObject otherObject;
    public Transform publicTransformReference; // Direct reference set in the Inspector
    private Rigidbody privateRigidbodyReference; // Private reference assigned dynamically

    void Start()
    {
        // 1. Accessing a component attached to the same GameObject
        privateRigidbodyReference = GetComponent<Rigidbody>();
        if (privateRigidbodyReference != null)
        {
            privateRigidbodyReference.useGravity = true;
            Debug.Log("Accessed Rigidbody on this GameObject.");
        }

        // 2. Accessing a component on another GameObject using a public reference
        if (publicTransformReference != null)
        {
            publicTransformReference.position = new Vector3(0, 5, 0);
            Debug.Log("Modified position of public Transform reference.");
        }

        // 3. Finding a component dynamically in children
        Transform childTransform = transform.Find("Child");
        if (childTransform != null)
        {
            childTransform.localScale = Vector3.one * 2;
            Debug.Log("Scaled a child object dynamically.");
        }

        // 4. Finding a component on a specific GameObject by tag
        GameObject taggedObject = GameObject.FindGameObjectWithTag("Player");
        if (taggedObject != null)
        {
            Renderer renderer = taggedObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = Color.red;
                Debug.Log("Changed color of tagged GameObject.");
            }
        }

        // 5. Communicating with another component via GetComponentInChildren
        Renderer childRenderer = GetComponentInChildren<Renderer>();
        if (childRenderer != null)
        {
            childRenderer.material.color = Color.blue;
            Debug.Log("Changed color of first Renderer in children.");
        }

        // 6. Communicating with another component via GetComponentInParent
        Collider parentCollider = GetComponentInParent<Collider>();
        if (parentCollider != null)
        {
            parentCollider.isTrigger = true;
            Debug.Log("Set parent Collider to trigger.");
        }

        // 7. Accessing multiple components using GetComponents
        Collider[] colliders = GetComponents<Collider>();
        foreach (var col in colliders)
        {
            col.enabled = true;
            Debug.Log("Enabled a collider.");
        }

        // 8. Using SendMessage to invoke a method on a component on the same gameobject
        //SendMessage("ReceiveMessage", SendMessageOptions.DontRequireReceiver);

        // 9. Using BroadcastMessage to invoke a method on a component on the same gameObject or its children
        //BroadcastMessage("ReceiveMessage", SendMessageOptions.DontRequireReceiver);


        // 10. Direct interaction via a custom script
        /*CustomComponent customComponent = otherObject.GetComponent<CustomComponent>();
        if (customComponent != null)
        {
            customComponent.DoSomething();
        }*/
        
        // 11. Direct interaction via a custom script on multiple objects using FindObject
        /*CustomComponent[] customComponents = FindObjectsOfType<CustomComponent>();

        // Loop through each component and call DoSomething
        foreach (var customComp in customComponents)
        {
            customComp.DoSomething();
        }*/

    }

    
}
