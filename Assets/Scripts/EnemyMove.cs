using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() 
    {
        rb.MovePosition(transform.position + Vector3.left * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Player destroyed!");
        }
        if (collision.gameObject.CompareTag("Castle"))
        {
            Debug.Log("Game Over");
            GameManager.Instance.GameOver();
        }
    }
}
