using UnityEngine;
using System.Collections;
using System.Threading;

public class WaveManager : MonoBehaviour {

    // wave or level number
    public int wave = 1;

    //Monster gameobjects
    [Header("Reference to unit game objects")]
    public GameObject Aswang;
    public GameObject Manananggal;
    public GameObject Tsanak;
    public GameObject Kapre;

    //Health potions
    public GameObject Potion;

    [Header("Spawn points transform reference")]
    //spawn points
    public Transform[] spawnPoints;
    //spawn index
    private int spawnIndex;

    //number of units you want to summon
    [Header("Amount of units to summon on this wave")]
    public int numAswang;
    public int numManananggal;
    public int numTsanak;
    public int numKapre;
    public int numPotion;

    [Header("Delay between spawn time in sec")]
    public int spawnDelay;
    //timer for invoke
    public float timer;

    // Use this for initialization
    void Start () {

        /* switch (wave)
         {
             case 1:
                 waveSpawn(4, 0, 0, 0, 0);
                 break;
             case 2:
                 waveSpawn(6, 1, 0, 0, 1);
                 break;
             case 3:
                 waveSpawn(6, 2, 1, 0, 0);
                 break;
             case 4:
                 waveSpawn(8, 4, 2, 0, 1);
                 break;
             case 5:
                 waveSpawn(8, 4, 2, 1, 2);
                 break;
             case 6:
                 waveSpawn(10, 6, 5, 0, 0);
                 break;
             case 7:
                 waveSpawn(12, 8, 6, 1, 1);
                 break;
             case 8:
                 waveSpawn(12, 8, 8, 2, 1);
                 break;
             case 9:
                 waveSpawn(12, 10, 10, 2, 2);
                 break;
             case 10:
                 waveSpawn(0, 0, 0, 8, 4);
                 break;
             default:
                 break;
         }
         //wave = PlayerPrefs.GetInt("wave");
         */

        //start summoning Aswang
        InvokeRepeating("spawnAswang", 5, spawnDelay);
        //start summoning Manananggal
        InvokeRepeating("spawnManananggal", 11, spawnDelay);
        //start summoning Tsanak
        InvokeRepeating("spawnTsanak", 17, spawnDelay);
        //start summoning Kapre
        InvokeRepeating("spawnKapre", 23, spawnDelay);
        //start summoning Potion
        InvokeRepeating("spawnPotion", 29, spawnDelay);
    }
	
	// Update is called once per frame
	void Update () {

        //randomize spawn point
        spawnIndex = Random.Range(0, spawnPoints.Length);

        //count up timer for cancelling invoke
        timer += Time.deltaTime;

        //stop spawning Aswang if...
        if (timer>=(numAswang*spawnDelay)+5)
        {
            CancelInvoke("spawnAswang");
        }
        //stop spawning Manananggal if...
        if (timer >= (numManananggal * spawnDelay)+11)
        {
            CancelInvoke("spawnManananggal");
        }
        //stop spawning Tsanak if...
        if (timer >= (numTsanak * spawnDelay)+17)
        {
            CancelInvoke("spawnTsanak");
        }
        //stop spawning Kapre if...
        if (timer >= (numKapre * spawnDelay)+23)
        {
            CancelInvoke("spawnKapre");
        }
        //stop spawning Potion if...
        if (timer >= (numPotion * spawnDelay)+29)
        {
            CancelInvoke("spawnPotion");
        }

    }

    //wave RuleSet
    void waveRuleSet()
    {
        

    }
    
    //spawn Aswang function
    void spawnAswang()
    {
        Instantiate(Aswang, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
    //spawn Manananggal function
    void spawnManananggal()
    {
        Instantiate(Manananggal, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
    //spawn Tsanak function
    void spawnTsanak()
    {
        Instantiate(Tsanak, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
    //spawn Kapre function
    void spawnKapre()
    {
        Instantiate(Kapre, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
    //spawn Potion function
    void spawnPotion()
    {
        Instantiate(Potion, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }

    //spawn monsters depending on wave
    void waveSpawn(int numAswang, int numManananggal, int numTsanak, int numKapre, int numPotion)
    {
        
        //spawn aswang
        for (int i = 0; i < numAswang; i++)
        {
            Instantiate (Aswang, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
        }
        //spawm mananannggal
        for (int i = 0; i < numManananggal; i++)
        {
            Instantiate(Kapre, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
        }
        //spawm tsanak
        for (int i = 0; i < numTsanak; i++)
        {
            Instantiate(Manananggal, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
        }
        //spawm kapre
        for (int i = 0; i < numKapre; i++)
        {
            Instantiate(Tsanak, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
        }
        //spawm potion
        for (int i = 0; i < numPotion; i++)
        {
            Instantiate(Potion, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
        }
      
    }

    /*
  void waveSpawn(string spawn)
  {
      int spawnIndex = Random.Range(0, spawnPoints.Length);
      //spawn aswang
      if (spawn == "aswang")
      {
          Instantiate (Aswang, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
      }
      //spawn kapre
      if (spawn == "kapre")
      {
          Instantiate(Kapre, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
      }
      //spawn manananggal
      if (spawn == "manananggal")
      {
          Instantiate(Manananggal, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
      }
      //spawn tsanak
      if (spawn == "tsanak")
      {
          Instantiate(Tsanak, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
      }
  }*/
}
