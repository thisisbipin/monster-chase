using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;
    private int randomIndex, randomSide;

    [SerializeField]
    private Transform leftPos, rightPos;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        coroutine = SpawnMonsters();
        StartCoroutine(coroutine);
    }
    IEnumerator SpawnMonsters()
    {
        while (true)
        {

            randomIndex = Random.Range(0, monsterReference.Length);

            randomSide = Random.Range(0, 2);

            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            if (randomSide == 0)
            {
                spawnedMonster.transform.position = leftPos.position;
                spawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 10);
            }
            else
            {
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4, 10);
                spawnedMonster.transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }
}
