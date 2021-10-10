using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reload : MonoBehaviour
{
    public Shooting shoot;
    public Text reloadtext;
    private int game = 0;
    // Start is called before the first frame update
    void Start()
    {
        shoot = FindObjectOfType<Shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shoot.currentAmo == game )
        {
            reloadtext.text = "Reloading".ToString();
        }
        else
        {
            reloadtext.text = shoot.currentAmo.ToString();
        }
        
    }
}
