using UnityEngine;

public class Blade : MonoBehaviour
{
    public AudioClip spawnSound;
    [Range(0f, 1f)] public float spawnVolume = 1f;

    void Start()
    {
        if (spawnSound != null)
            AudioSource.PlayClipAtPoint(spawnSound, transform.position, spawnVolume);
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().Damage(15);
            Destroy(gameObject);
        }
    }
}
