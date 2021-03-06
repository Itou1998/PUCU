﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
      public int startingHealth = 100;
      public int currentHealth;
      public int scoreValue = 10;

      CapsuleCollider capsuleCollider;
      bool isDead = false;

      // Start is called before the first frame update
      void Start()
      {
            capsuleCollider = GetComponent<CapsuleCollider>();

            currentHealth = startingHealth;
      }

      // Update is called once per frame
      void Update()
      {

      }

      public void TakeDamage(int amount)
      {
            if (isDead) return;

            currentHealth -= amount;

            if (currentHealth <= 0)
            {
                  Death();
            }
      }

      private void Death()
      {
            isDead = true;

            ScoreManager.score += scoreValue;
            Destroy(gameObject);
      }
}
