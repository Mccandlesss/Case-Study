using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    public Animator EnemyBasket;
    public Animator Enemy;
    public Animator Camera;
    public Animator EnemyRun;
    public Animator PoliceRun;
    public GameObject particle;
    public GameObject Wine;


    private void Start()
    {
        particle.SetActive(false);
        Wine.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Enemy.SetBool("Fall", true);
            EnemyBasket.SetBool("FallingBasket", true);
            particle.SetActive(true);
            EnemyRun.SetBool("Run", true);
            PoliceRun.SetBool("Step3", true);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Camera.enabled = !Camera.enabled;
            PoliceRun.SetBool("Step2", true);
            Wine.SetActive(false);
        }
    }
}
