using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonShoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Goshoot());
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
  

    public IEnumerator Goshoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = transform.right * bulletForce;

        }

    }
}
