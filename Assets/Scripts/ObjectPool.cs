using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public int AmountToPool = 20;
    public GameObject GameObjectToPool;

    private List<GameObject> poolObjects = new List<GameObject>(); 
    
    void Start()
    {
        CreatePool();
    }

    void CreatePool()
    {
        for ( int i = 0; i < AmountToPool; i++ )
        {
            var tempGO = Instantiate( GameObjectToPool );
            tempGO.SetActive( false );
            poolObjects.Add( tempGO );
        }
    }

    public GameObject GetGameObjectFromPool()
    {
        for ( int i = 0; i < poolObjects.Count; i++ )
        {
            if ( !poolObjects[ i ].activeInHierarchy )
            {
                return poolObjects[ i ];
            }
        }
        
        Debug.LogError( "No GameObject who's not active found. Instantiated instead (Which is a performance hit!). Increase the number of objects in the pool!!" );
        return null;
    }
}
