using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public int amountToPool;
    public GameObject[] objectToPool;
    public static ObjectPool SharedInstense;
    public List<GameObject> pooledObjects;

    

    // Start is called before the first frame update
    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i=0;i< amountToPool;i++)
        {
            Debug.Log("count " + i);
                int index = Random.Range(0, objectToPool.Length);
                tmp = Instantiate(objectToPool[index]);
                tmp.SetActive(false);
                pooledObjects.Add(tmp);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        SharedInstense = this;
    }

    public GameObject GetPooledObject(){
        for(int i=0; i<amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }

        }
        return null;
    }

}
