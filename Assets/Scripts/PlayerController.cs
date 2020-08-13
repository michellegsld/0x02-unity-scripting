using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public int health = 5;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2.5f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown("w"))
        {
            Vector3 position = this.transform.position;
            position.z += speed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown("a"))
        {
            Vector3 position = this.transform.position;
            position.x += speed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown("s"))
        {
            Vector3 position = this.transform.position;
            position.z -= speed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown("d"))
        {
            Vector3 position = this.transform.position;
            position.x -= speed;
            this.transform.position = position;
        }
    }

    // Increment the value of score when the Player touches the Pickup tag
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
    }
}
