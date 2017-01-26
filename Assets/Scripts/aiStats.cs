using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class aiStats : MonoBehaviour {
    //player stats script reference
	
    public PlayerStats pStats;
	private NavMeshAgent agent;
    //Choose a number that represents the creature
    [Header("1 = Aswang")]
    [Header("2 = Kapre")]
    [Header("3 = Manananggal")]
    [Header("4 = Tsanak")]
    public int Creature;

    [Header("Stats")]
    //creature stats
	public float MaxHP=100.0f;
    public float aiHealth;
	public Image HP;
    public int aiDamage;
    public float aiMoveSpeed;
    public float aiAttackSpeed;
  
    //chance if ai will drop ammo
    public int chance;
    public bool dropAmmo = false;
    public bool dropGold = false;

    //Game Objects of ammo and gold
    [Header("Place ammo gameobject here")]
    public GameObject Ammo;
    [Header("Place gold gameobject here")]
    public GameObject Gold;


    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        CreatureRuleSet();
		agent.speed = aiMoveSpeed;
    }

 void OnTriggerEnter(Collider other) {
        if(other.tag =="weapon"){
			
			aiHealth -=10;
		}
		
		
    }
	
    void Update()
    {
      HP.fillAmount = aiHealth/MaxHP;

        //chance if ammo or gold will drop when ai dies
        chance = Random.Range(1, 10);
        
        if (aiHealth == 0)
        {
            PlayerStats.pKills += 1;
            Destroy(this.gameObject);
            
            //drop gold
            if (chance <= 5)
            {
                dropGold = true;
            }
            //drop ammo
            else if (chance >= 6)
            {
                dropAmmo = true;
            }
                
        }

        //instantiate gold
        if (dropGold==true)
        {
            Rigidbody cloneGold = Instantiate(Gold, this.transform.position, this.transform.rotation) as Rigidbody;
        }
        //instantiate ammo
        else if (dropAmmo == true)
        {
            Rigidbody cloneAmmo = Instantiate(Ammo, this.transform.position, this.transform.rotation) as Rigidbody;
        }
    }


    //RuleSet
    void CreatureRuleSet()
    {
        switch (Creature)
        {
            case 1: //Aswang
                aiHealth = 100;
                aiDamage = 5;
                aiMoveSpeed = 2;
                aiAttackSpeed = 1;
                break;
            case 2: //Kapre
                aiHealth = 1000;
                aiDamage = 50;
                aiMoveSpeed = 0.5f;
                aiAttackSpeed = 0.2f;
                break;
            case 3: //Manananggal
                aiHealth = 100;
                aiDamage = 10;
                aiMoveSpeed = 4;
                aiAttackSpeed = 1.5f;
                break;
            case 4: //Tsanak
                aiHealth = 200;
                aiDamage = 5;
                aiMoveSpeed = 8;
                aiAttackSpeed = 2;
                break;
            default:
                print("Invalid Value");
                break;
        }

    }
}
