using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 Transform = transform.position;
        Transform.x = Transform.x + 0.01f;
        transform.position = Transform;

    }
}
