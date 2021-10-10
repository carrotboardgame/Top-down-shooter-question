using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public int maxamo;
    public int currentAmo;
    public float reloadTime;
    public bool isReloading = false;
    public float bulletForce = 20f;
    public Text reloadText;

    private void Start()
    {
        currentAmo = maxamo;
    }

    // Update is called once per frame
    private void Update()
    {
        if(isReloading)
        {
            return;
        }
       if (currentAmo <= 0)
        {
            StartCoroutine( reload() );
            return;
        }

        if(Input.GetButtonDown("Fire1"))
        {
            Goshoot();
        }
    }

    public IEnumerator reload()
    {
        isReloading = true;
        Debug.Log("Reloading..");
        yield return new WaitForSeconds(reloadTime);
        currentAmo = maxamo;
        isReloading = false;
    }

   public void Goshoot()
    {
        currentAmo--;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
    
    
        
    
}
