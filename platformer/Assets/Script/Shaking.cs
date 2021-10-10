using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaking : MonoBehaviour
{
    public int waitime;

    public Quaternion rotate1;
    public Quaternion rotate2;
    public Quaternion rotate3;
    
    

    // Start is called before the first frame update
    void Start()
    {
        rotate1 = transform.rotation;
        rotate2 = transform.rotation;
        rotate3 = transform.rotation;
        StartCoroutine(Shake());


    }    // Update is called once per frame
    
    void Update ()
    {
        Invoke("call", 3);
            
    }

    private void call()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, -13f);
        yield return new WaitForSeconds(waitime);
        transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        yield return new WaitForSeconds(waitime);
        transform.localRotation = Quaternion.Euler(0f, 0f, 13f);
        yield return new WaitForSeconds(waitime);
        transform.localRotation = Quaternion.Euler(0f, 0f, 0f);


    }  
}
