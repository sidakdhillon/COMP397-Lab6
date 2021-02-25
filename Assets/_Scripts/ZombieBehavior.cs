using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieBehavior : MonoBehaviour
{
    private Animator animator

    private NavMeshAgent agent;

    void Start()
    {
		animator = GetComponent<Animator>();
		agent = GetComponent<NavMeshAgent>();    
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKeyDown(KeyCode.I))
    	{
    		animator.SetInteger("AnimState", (int)ZombieState.IDLE);
    	}

    	if(Input.GetKeyDown(KeyCode.U))
    	{
    		animator.SetInteger("AnimState", (int)ZombieState.RUN);
    	}

    	if(Input.GetKeyDown(KeyCode.J))
    	{
    		animator.SetInteger("AnimState", (int)ZombieState.JUMP);
    	}

        
    }
}
