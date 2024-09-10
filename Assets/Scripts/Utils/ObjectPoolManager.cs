using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace meekobytes
{
    public class ObjectPoolManager : MonoBehaviour
    {
        public static List<PooledObjectInfo> ObjectPools = new List<PooledObjectInfo>();
        public static GameObject SpawnObject(GameObject objectToSpawn, Vector3 spawnPosition, Quaternion spawnRotation)
        {
            PooledObjectInfo pool = ObjectPools.Find(p => p.LookupID == objectToSpawn.GetComponentInParent<UniqueID>().ID);
            if(pool == null)
            {
                pool = new PooledObjectInfo() { LookupID = objectToSpawn.GetComponent<UniqueID>().ID};
                ObjectPools.Add(pool);
            }

            GameObject spawnableObj = pool.InactiveObjects.FirstOrDefault();

            if(spawnableObj == null)
            {
                spawnableObj = Instantiate(objectToSpawn, spawnPosition, spawnRotation);
            }
            else
            {
                spawnableObj.transform.SetPositionAndRotation(spawnPosition, spawnRotation);
                pool.InactiveObjects.Remove(spawnableObj);
                spawnableObj.SetActive(true);
            }

            return spawnableObj;
        }
        public static void ReturnObjectToPool(GameObject obj)
        {
            string goName = obj.name.Substring(0, obj.name.Length - 7);
            PooledObjectInfo pool = ObjectPools.Find(p => p.LookupID == obj.GetComponent<UniqueID>().ID);

            if(pool == null)
            {
                Debug.LogWarning("Trying to release an object that is not pooled: " + obj.name);
            }
            else
            {
                obj.SetActive(false);
                pool.InactiveObjects.Add(obj);
            }
        }
    }
    public class PooledObjectInfo
        {
            public string LookupID;
            public List<GameObject> InactiveObjects = new List<GameObject>();
        }
    }