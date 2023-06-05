using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class stop : StateMachineBehaviour
{

   
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NavMeshAgent agent = FindObjectOfType<Boss>().GetComponent<NavMeshAgent>();
        agent.isStopped = true;
    }

    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NavMeshAgent agent = FindObjectOfType<Boss>().GetComponent<NavMeshAgent>();
        agent.isStopped = true;
    }

    
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NavMeshAgent agent = FindObjectOfType<Boss>().GetComponent<NavMeshAgent>();
        agent.isStopped = false;
    }
}