using UnityEngine;

public class Turret : MonoBehaviour
{
    public ObjectPool turretObjectPool;
    public Transform SpawnLocation;

    void Update()
    {
        Debug.Log("UP");
        if ( Input.GetKeyDown( KeyCode.Space ) )
        {
            var GO = turretObjectPool.GetGameObjectFromPool();
            if ( GO == null ) return;
            GO.transform.position = SpawnLocation.position;
            GO.SetActive( true );
        }
    }
}