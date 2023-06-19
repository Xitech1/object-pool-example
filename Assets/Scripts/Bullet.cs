using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float waitTimeInSeconds = 4f;
    
    IEnumerator DisableGameObject()
    {
        yield return new WaitForSeconds( waitTimeInSeconds );
        gameObject.SetActive( false );
    }

    private void OnEnable()
    {
        StartCoroutine( DisableGameObject() );
    }

    private void Update()
    {
        transform.Translate( Vector3.forward * Time.deltaTime * 20 );
    }
}
