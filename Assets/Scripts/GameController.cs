using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject EnemyFolder;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("RandomCreateEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator RandomCreateEnemy()
    {
        float duration = Random.Range(0.2f, 2f);
        yield return new WaitForSeconds(duration);
        CreateEnemy();
        StartCoroutine("RandomCreateEnemy");

    }

    void CreateEnemy()
    {
        float posX = Random.Range(-2f, 2f);
        GameObject newEnemy = Instantiate(Enemy, EnemyFolder.transform);
        newEnemy.transform.position += new Vector3(posX, 0, 0);
    }
}
