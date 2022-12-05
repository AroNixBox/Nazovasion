using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Slider playerHealthBar;
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;

    private void Start()
    {
        health = maxHealth;
    }
    private void Update()
    {
        playerHealthBar.value = health;
    }
    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0f)
        {
            health = 0f;
            Debug.Log("Player Respawn");
            SceneManager.LoadScene("GameScene");
        }
    }
}
