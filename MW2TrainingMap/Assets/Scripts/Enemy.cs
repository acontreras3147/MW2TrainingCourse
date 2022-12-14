using System.Threading;
using UnityEngine;
using System.Windows;
using TMPro;

public class Enemy : MonoBehaviour
{
    public float health = 50f;
    private AudioSource audiosrc;
    public AudioClip deathSound1;
    public AudioClip deathSound2;
    public static int numEnemies = 14;
    private bool isplaying = false;
    //reducing enemy health by damage set from gun
   
    private void Awake()
    {
        audiosrc = GetComponent<AudioSource>();
        
    }
    public void takeDamage(float amountDamage)
    {
        health -= amountDamage;

        if (health <= 0f & isplaying == false)
        {
            isplaying = true;
            audiosrc.PlayOneShot(deathSound1);
            enemyDie();
            numEnemies--;
            

        }
       
    }

    //have the enemy "die"
    void enemyDie()
    {
        Destroy(gameObject,deathSound1.length);
    }
    void playSound()
    {
        audiosrc.PlayOneShot(deathSound1);
    }
    
}
