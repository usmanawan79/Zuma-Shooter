using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPositions;
    public GameObject[] objPrefabs;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        //StartCoroutine(SpawnLoop());
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(SpawnLoop());
    }


    IEnumerator Spawn()
    {
        for(int i=0; i<= spawnPositions.Length; i++)
        {
            int index = Random.Range(0, 3);
           var obj =  Instantiate(objPrefabs[index], spawnPositions[i].position, Quaternion.identity);
            obj.transform.parent = spawnPositions[i].transform;
            yield return new WaitForSeconds(0.2f);

        }

        yield return new WaitForSeconds(1);
        
    }

    //IEnumerator SpawnLoop()
    //{
        
    //    for (int i = 0; i <= spawnPositions.Length; i++)
    //    {
    //        if(spawnPositions[i].parent == null)
    //        {
    //            int index = Random.Range(0, 3);
    //            var obj = Instantiate(objPrefabs[index], spawnPositions[i].position, Quaternion.identity);
    //            obj.transform.parent = spawnPositions[i].transform;
    //        }
    //        else
    //        {
    //            yield return new WaitForSeconds(2);
    //        }
    //    }
    //    yield return new WaitForSeconds(1);
    //}

}
