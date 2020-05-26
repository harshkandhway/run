﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gems : MonoBehaviour
{
    private UI ui;
    TextMeshProUGUI gem;
    void Start()
    {
        ui = GameObject.Find("Canvas").GetComponent<UI>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Object.notMove == false)
            transform.Translate(Vector3.left * Object.speed * Time.deltaTime);
        if (transform.position.x <= -11.55f)
        {
            Destroy(this.gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Player p = other.GetComponent<Player>();
        if (other.tag == "play")
        {
            if (other.name != null)
            {
                if (MainMenu.isSoundOn==0)
                    FindObjectOfType<audioScript>().playSound("gems");
                ui.updateLifeGem();
                Destroy(this.gameObject);
                Player.isGlide = true;
            }
        }
    }
   
}
