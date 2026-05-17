using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance;

    public GameObject normalEnemy;
    public GameObject fastEnemy;
    public GameObject strongEnemy;
    public GameObject bossEnemy;

    public Transform[] spawnRows;

    public int aliveEnemies = 0; 
    public bool allWavesDone = false;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        StartCoroutine(StartWaves());
    }

    IEnumerator StartWaves()
    {
        // WAVE 1
        GameManager.Instance.ShowWave(1);
        yield return StartCoroutine(SpawnOneByOne(normalEnemy, 10, 10f));
        yield return new WaitForSeconds(15f);
        yield return StartCoroutine(SpawnBatch(normalEnemy, 5));

        // WAVE 2
        GameManager.Instance.ShowWave(2);
        yield return new WaitForSeconds(10f);
        yield return StartCoroutine(SpawnOneByOne(normalEnemy, 10, 8f));
        yield return StartCoroutine(SpawnOneByOne(fastEnemy, 8, 8f));
        yield return StartCoroutine(SpawnBatch(fastEnemy, 8));

        // WAVE 3
        GameManager.Instance.ShowWave(3);
        yield return new WaitForSeconds(10f);
        yield return StartCoroutine(SpawnOneByOne(normalEnemy, 10, 4f));
        yield return StartCoroutine(SpawnOneByOne(fastEnemy, 10, 4f));
        yield return StartCoroutine(SpawnOneByOne(strongEnemy, 10, 4f));
        yield return StartCoroutine(SpawnBatch(normalEnemy, 10));
        yield return StartCoroutine(SpawnBatch(fastEnemy, 8));
        yield return StartCoroutine(SpawnBatch(strongEnemy, 10));

        // WAVE 4 (Boss)
        GameManager.Instance.ShowWave(4);
        yield return new WaitForSeconds(15f);
        yield return StartCoroutine(SpawnOneByOne(normalEnemy, 12, 3f));
        yield return StartCoroutine(SpawnOneByOne(fastEnemy, 10, 3f));
        yield return StartCoroutine(SpawnOneByOne(strongEnemy, 12, 3f));

        // Boss 
        SpawnEnemy(bossEnemy);

        yield return StartCoroutine(SpawnBatch(normalEnemy, 12));
        yield return StartCoroutine(SpawnBatch(fastEnemy, 10));
        yield return StartCoroutine(SpawnBatch(strongEnemy, 12));

        allWavesDone = true;
    }

    IEnumerator SpawnOneByOne(GameObject enemyPrefab, int count, float delay)
    {
        for (int i = 0; i < count; i++)
        {
            SpawnEnemy(enemyPrefab);
            yield return new WaitForSeconds(delay);
        }
    }

    // Ek sath spawn
    IEnumerator SpawnBatch(GameObject enemyPrefab, int count)
    {
        for (int i = 0; i < count; i++)
        {
            SpawnEnemy(enemyPrefab);
        }
        yield return null;
    }

    // Enemy ko spawn karna
    void SpawnEnemy(GameObject enemyPrefab)
    {
        if (spawnRows.Length == 0) return;

        Transform row;

        if (enemyPrefab == bossEnemy)
        {
            row = spawnRows[2];
        }
        else
        {
            row = spawnRows[Random.Range(0, spawnRows.Length)];
        }

        Instantiate(enemyPrefab, row.position, Quaternion.Euler(0, 270, 0));
        aliveEnemies++;
    }

    public void EnemyDied()
    {
        aliveEnemies--; 

        if (aliveEnemies <= 0)
        {
            if (allWavesDone)
            {
                if (GameManager.Instance != null)
                    GameManager.Instance.Victory();
            }
        }
    }
}
