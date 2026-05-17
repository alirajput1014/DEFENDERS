using UnityEngine;

public class ElectricShock : MonoBehaviour
{
    public AudioClip spawnSound;
    [Range(0f, 1f)] public float spawnVolume = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (spawnSound != null)
            AudioSource.PlayClipAtPoint(spawnSound, transform.position, spawnVolume);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().Damage(25);
            Destroy(gameObject);
        }
    }
}
