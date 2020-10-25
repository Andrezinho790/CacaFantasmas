using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    GameObject[] itensArremessaveis;
    public Transform target;
    NavMeshAgent agent;
    bool EstaArremessando;
    int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        EstaArremessando = false;
        itensArremessaveis = GameObject.FindGameObjectsWithTag("Arremessaveis");
        //target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);


         ArremessarItem();
        
        
        

        
    }

    void ArremessarItem()
    {
        
        if (!EstaArremessando)
        {
            randomNumber = Random.Range(0, itensArremessaveis.Length);
        }
        if (itensArremessaveis[randomNumber] != null)
        {
            Debug.Log(itensArremessaveis[randomNumber]);
            EstaArremessando = true;
            agent.SetDestination(itensArremessaveis[randomNumber].transform.position);
        }
    }
}
