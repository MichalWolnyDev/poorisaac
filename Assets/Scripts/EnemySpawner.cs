using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] // with this our gameobject is accesible via inspector
    private GameObject firstEnemyPrefab;
    [SerializeField] 
    private GameObject secondEnemyPrefab;
    [SerializeField] 
    private GameObject thirdEnemyPrefab;


    [SerializeField] 
    private float firstEnemyInterval = 3.5f; // interval of spawning
    [SerializeField] 
    private float secondEnemyInterval = 10f;
    [SerializeField] 
    private float thirdEnemyInterval = 4f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(firstEnemyInterval, firstEnemyPrefab));
        StartCoroutine(spawnEnemy(secondEnemyInterval, secondEnemyPrefab));
        StartCoroutine(spawnEnemy(thirdEnemyInterval, thirdEnemyPrefab));
    }

    // ienumerator allows to iterate through object no matter what their access modifier is
    private IEnumerator spawnEnemy(float interval, GameObject enemy){
        yield return new WaitForSeconds(interval);

        // GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f,3), Random.Range(-4f, 4f), 0), Quaternion.identity);
        // gameObject.transform.position -> spawner position on map
        GameObject newEnemy = Instantiate(enemy, gameObject.transform.position, Quaternion.identity);

        // couroutine is a function that can suspend its execution until the given yield instrucion finishes
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
