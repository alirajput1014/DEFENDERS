using UnityEngine;

public class WizardProjectile : MonoBehaviour
{
    public GameObject FirePrefab;
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
        GameObject Fire = Instantiate(FirePrefab, transform.position, Quaternion.Euler(0, 90, 0));
        rb = Fire.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.right * speed;
        Destroy(Fire, 10f);
    }
}
