using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {
    //wave manager script ref
    private WaveManager wavemanager;
    //ai stats script ref
    private aiStats aiStats;

    //player stats
    [Header("Player stats")]
    public static float pHealth = 100f;

    public int pGold;
    public int pAmmo;
    public static int pKills;

    [Header("Wave kill goal")]
    public int KillGoal;

    //weapon damage
    [Header("Weapon damage")]
    public int dmgBalisong = 50;
    public int dmgKally = 70;
    public int dmgArrow ;
    public int dmgSpear = 50;
    public int dmgSumpak;
    public int dmgGlockPistol;

    //UI elements
    [Header("UI text ref")]
    public Text txtHealth;
    public Text txtAmmo;
    public Text txtGold;
    public Text txtKills;

  

    void Start()
    {
        //load stats from previous wave at start
        if (wavemanager.wave==1)
        {
            return;
        }
        else
        {
            pHealth = PlayerPrefs.GetInt("pHealth");
            pGold = PlayerPrefs.GetInt("pGold");
            pAmmo = PlayerPrefs.GetInt("pAmmo");
            pKills = PlayerPrefs.GetInt("pKills");
        }

    }

    void Update()
    {
        //display player stats on UI
        txtHealth.text = "Health: " + pHealth;
        txtAmmo.text = "Ammo: " + pAmmo;
        txtGold.text = "Gold: " + pGold;
        txtKills.text = "Kills: " + pKills;

        /*sets and saves what wave it is and the player stats
        if (wavemanager.wave == 1)
        {
            PlayerPrefs.SetInt("pHealth", 100);
            PlayerPrefs.SetInt("pGold", 0);
            PlayerPrefs.SetInt("pAmmo", 0);
            PlayerPrefs.SetInt("pKills", 0);
        }
        else if (wavemanager.wave == 1 && pKills == 4)
        {
            PlayerPrefs.SetInt("wave", 2);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
            
        }
        else if (wavemanager.wave == 2 && pKills == 7)
        {
            PlayerPrefs.SetInt("wave", 3);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
           
        }
        else if (wavemanager.wave == 3 && pKills == 9)
        {
            PlayerPrefs.SetInt("wave", 4);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
            
        }
        else if (wavemanager.wave == 4 && pKills == 14)
        {
            PlayerPrefs.SetInt("wave", 5);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
            
        }
        else if (wavemanager.wave == 5 && pKills == 15)
        {
            PlayerPrefs.SetInt("wave", 6);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
      
        }
        else if (wavemanager.wave == 6 && pKills == 21)
        {
            PlayerPrefs.SetInt("wave", 7);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
     
        }
        else if (wavemanager.wave == 7 && pKills == 27)
        {
            PlayerPrefs.SetInt("wave", 8);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
           
        }
        else if (wavemanager.wave == 8 && pKills == 30)
        {
            PlayerPrefs.SetInt("wave", 9);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
            
        }
        else if (wavemanager.wave == 9 && pKills == 34)
        {
            PlayerPrefs.SetInt("wave", 10);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
        
        }
        else if (wavemanager.wave == 10 && pKills == 8)
        {
            PlayerPrefs.SetInt("wave", 10);
            PlayerPrefs.SetInt("pHealth", pHealth);
            PlayerPrefs.SetInt("pGold", pGold);
            PlayerPrefs.SetInt("pAmmo", pAmmo);
            PlayerPrefs.SetInt("pKills", pKills);
           
        }*/

       
        //amount of kills to achieve to reach next wave
        if (pKills==KillGoal)
        {
            SceneManager.LoadScene("shop");
        }
    }


   

    //detect whether the item is an ammo, gold, or potion and takes its effect
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag =="aswangGold")
        {
            pGold += Random.Range(100, 200);
        }
        else if (col.gameObject.tag == "aswangAmmo")
        {
            pAmmo += Random.Range(2, 3);
        }
        else if (col.gameObject.tag == "kapreGold")
        {
            pGold += Random.Range(4000, 5000);
        }
        else if (col.gameObject.tag == "kapreAmmo")
        {
            pAmmo += Random.Range(15, 20);
        }
        else if (col.gameObject.tag == "manGold")
        {
            pGold += Random.Range(800, 1000);
        }
        else if (col.gameObject.tag == "manAmmo")
        {
            pAmmo += Random.Range(8, 10);
        }
        else if (col.gameObject.tag == "tsanakGold")
        {
            pGold += Random.Range(600, 800);
        }
        else if (col.gameObject.tag == "tsanakAmmo")
        {
            pAmmo += Random.Range(4, 6);
        }
        else if (col.gameObject.tag == "potion")
        {
            pHealth += Random.Range(20, 30);
        }
    }
}
