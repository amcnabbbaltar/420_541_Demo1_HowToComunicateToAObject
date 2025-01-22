using UnityEngine;

public class ExposeVariablesExample : MonoBehaviour
{
    // 1. Public variable (directly accessible and editable in the Inspector)
    public int publicInt = 10;

    // 2. [SerializeField] for a private variable (editable in the Inspector but not accessible from other scripts)
    [SerializeField] private float privateFloat = 3.5f;

    // 3. [SerializeField] with a property for controlled access
    [SerializeField] private string privateString = "Hello";
    public string PrivateString
    {
        get { return privateString; }
        set { privateString = value; }
    }

    // 4. Public property (not visible in the Inspector but accessible from other scripts)
    public bool PublicProperty { get; set; } = true;

    // 6. Exposing constants (not editable but accessible everywhere)
    public const string ConstantString = "This is a constant";

    // 7. Using ScriptableObjects for shared data
    public SharedData sharedData;

    // 8. Exposing a variable through a [Range] attribute
    [Range(0, 100)] public int rangeInt = 50;

    // 9. Exposing a variable through a [Tooltip] for additional context
    [Tooltip("This is a health value ranging from 0 to 100.")]
    public int health = 100;

    // 10. Exposing a variable with a [Header] for better grouping
    [Header("Group A")]
    public GameObject linkedObject;

    [Header("Group B")]
    public Transform targetTransform;

    // 11. Using [HideInInspector] to keep a public variable hidden from the Inspector
    [HideInInspector] public string hiddenFromInspector = "Hidden!";

    // 12. Exposing enums
    public enum PlayerState { Idle, Running, Jumping, Attacking }
    public PlayerState currentPlayerState;

    void Start()
    {
        Debug.Log("Public Int: " + publicInt);
        Debug.Log("Private Float (via SerializeField): " + privateFloat);
        Debug.Log("Private String (via Property): " + PrivateString);
        Debug.Log("Public Property: " + PublicProperty);
        Debug.Log("Constant String: " + ConstantString);
        Debug.Log("Range Int: " + rangeInt);
        Debug.Log("Health: " + health);
        Debug.Log("Hidden From Inspector: " + hiddenFromInspector);
        Debug.Log("Player State: " + currentPlayerState);
    }
}



