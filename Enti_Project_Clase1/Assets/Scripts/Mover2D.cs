using UnityEngine;
using UnityEngine.InputSystem;

public class Mover2D : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    private Vector3 dir = new Vector3(0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("W");
            dir.y = 1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("A");
            dir.x = -1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("S");
            dir.y = -1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("D");
            dir.x = 1;
        }

        transform.position += dir * speed * Time.deltaTime;
    }
}
