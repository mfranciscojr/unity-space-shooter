using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    [SerializeField]
    private float _laserfire = 8.0f;
    [SerializeField]
    private float _laserLimit = 6.7f;
 
    void Update()
    {
        transform.Translate(Vector3.up * _laserfire * Time.deltaTime);
        if(transform.position.y >= _laserLimit)
        {
            Destroy(this.gameObject);
        }



       
    }
}
