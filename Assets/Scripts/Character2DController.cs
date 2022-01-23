using UnityEngine;

public class Character2DController : MonoBehaviour
{
    public float MovementSpeed = 4;

    private void Start()
    {
        
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0 , 0) * Time.deltaTime * MovementSpeed;
    }
}
