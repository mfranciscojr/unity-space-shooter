using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private GameObject _enemy;
    [SerializeField]
    private float accelaration = 4.0f;
    void Start()
    {
        transform.position = new Vector3(Random.Range(-9.8f, 9.8f), 6.6f, 0);
    }

    void Update()
    {
        transform.Translate(Vector3.down * accelaration * Time.deltaTime);
        if (transform.position.y <= -5.3f)
        {
            transform.position = new Vector3(Random.Range(-9.8f, 9.8f), 6.6f, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            player player = other.transform.GetComponent<player>();

            if (player != null)
            {
                player.Damage();
            }
            Destroy(this.gameObject);
         
        }
        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }
    }
}
