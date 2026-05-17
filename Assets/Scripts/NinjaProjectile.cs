using UnityEngine;

public class NinjaProjectile : MonoBehaviour
{
    public GameObject BladePrefab;
    public float speed;
    private Rigidbody rb;
    public float interval;
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
        GameObject blade = Instantiate(BladePrefab, transform.position, Quaternion.Euler(0,90,0));
        rb = blade.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.right * speed;
        Destroy(blade, 10f);
    }
   

}
