using UnityEngine;

public class ArcherProjectile : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public float speed;
    private Rigidbody rb;
    public float interval = 3.5f;
    private GameObject Arrow;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Throw", 1, interval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void Throw()
    {
        Arrow = Instantiate(ArrowPrefab, transform.position, Quaternion.Euler(0, 90, 0));
        rb = Arrow.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.right * speed;

        Destroy(Arrow, 10f);

    }
}
