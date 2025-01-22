using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Example of a ScriptableObject for shared data
[CreateAssetMenu(fileName = "SharedData", menuName = "Example/Shared Data")]
public class SharedData : ScriptableObject
{
    public int sharedValue = 42;
}

