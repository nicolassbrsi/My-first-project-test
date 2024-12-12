using UnityEngine;
using UnityEngine.Windows.Speech;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;
    public GameObject door;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rigidbody2d.linearVelocity = new Vector2(speed, 0f);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rigidbody2d.linearVelocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            rigidbody2d.linearVelocity = new Vector2(0f, speed);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rigidbody2d.linearVelocity = new Vector2(0f, -speed);
        }
        else if (!(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0))
        {
            rigidbody2d.linearVelocity = new Vector2(0f, 0f);
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (door == null)
            door = GameObject.FindWithTag("Door");
        Debug.Log("Level Complete!!");
    }


}