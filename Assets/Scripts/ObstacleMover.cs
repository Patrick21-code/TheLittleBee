using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //delta time to make it frame independent
        if (transform.position.x < -10f)
        {
            Destroy(gameObject); //basically means me
        }
    }
}
