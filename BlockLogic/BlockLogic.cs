using UnityEngine;
using System.Collections;

public class BlockLogic : MonoBehaviour
{
    public int value;
    private float speed = 3f;
    // Use this for initialization
    void Start()
    {
        value = Random.Range(1, 20);
    }

    public void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
