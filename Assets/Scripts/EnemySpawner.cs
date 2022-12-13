using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   
    [SerializeField]
    public int enemyNumber;

    [SerializeField]
    private GameObject[] enemyPrefabs;

    [SerializeField]
    private float[] enemyIntervals;

    [SerializeField]
    public bool spawning;
    [SerializeField]
    public bool defeated;


    private int enemyCounter = 0;

    // Start is called before the first frame update
    void Start()
    {

        if(spawning && !defeated){
            for(int i = 0; i < enemyPrefabs.Length; i++){

            if(enemyCounter < enemyNumber) {
                    StartCoroutine(spawnEnemy(enemyIntervals[i], enemyPrefabs[i]));
                    enemyCounter ++;
            }

        }
        }
       
    }

    private void Update(){
        if(spawning && !defeated){
            for(int i = 0; i < enemyPrefabs.Length; i++){

            if(enemyCounter < enemyNumber) {
                    StartCoroutine(spawnEnemy(enemyIntervals[i], enemyPrefabs[i]));
                    enemyCounter ++;
            }

        }
        }
    }

    // ienumerator allows to iterate through object no matter what their access modifier is
    private IEnumerator spawnEnemy(float interval, GameObject enemy){
        yield return new WaitForSeconds(interval);

        // GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f,3), Random.Range(-4f, 4f), 0), Quaternion.identity);
        // gameObject.transform.position -> spawner position on map
        GameObject newEnemy = Instantiate(enemy, gameObject.transform.position, Quaternion.identity);

        // couroutine is a function that can suspend its execution until the given yield instrucion finishes
        if(enemyCounter < enemyNumber) {
            StartCoroutine(spawnEnemy(interval, enemy));
            enemyCounter++;
        }
    }
}
