using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSearchingForPlayer : State
{
    private bool reachedSearchPosition = false;
    private float searchTime = 5f;
    private float currentSearchTime = 0f;
    public StateSearchingForPlayer(AIController ai) : base(ai) { }
    // Start is called before the first frame update
   public override void Enter()
   {
        ai.agent.SetDestination(ai.lastKnownPlayerPos); 
        reachedSearchPosition=false;
        currentSearchTime = 0f;
   }
   

    // Update is called once per frame
   public override void Update()
   {
        //if plaeyr spotted chase them
        if(ai.CanSeePlayer())
        {
            ai.ChangeState(new StateChase(ai));
            return;
        }
        //wait until AI reaches search position (last known player pos
        if(!reachedSearchPosition)
        {
            if(ai.agent.remainingDistance <= ai.agent.stoppingDistance)
            {
                reachedSearchPosition=true;
            }
        }

        //look around for player here
        ai.transform.Rotate(Vector3.up * 60f * Time.deltaTime);

        //wait 5 seconds thne go back to patrol state
        currentSearchTime += Time.deltaTime;
        if(currentSearchTime >= searchTime)
        {
            ai.ChangeState(new StatePatrol(ai));
        }
   }

   public override void Exit()
   {

   
   }
}
