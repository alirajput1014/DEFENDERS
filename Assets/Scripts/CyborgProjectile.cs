using UnityEngine;

public class CyborgProjectile : MonoBehaviour
{
    public GameObject ElectricPrefab;
    public float speed;
    private Rigidbody rb;
    public float interval;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Throw", 2, interval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void Throw()
    {
        GameObject Electric = Instantiate(ElectricPrefab, transform.position, Quaternion.Euler(0, 90, 0));
        rb = Electric.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.right * speed;
        Destroy(Electric, 10f);
    }
}
