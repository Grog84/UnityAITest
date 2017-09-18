using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentBehaviour : MonoBehaviour {

    public GameObject target;
    protected Agent agent;

    public virtual Steering GetSteering()
    {
        return new Steering();
    }

    public virtual void Awake()
    {
        agent = gameObject.GetComponent<Agent>();
    }

    public virtual void Update()
    {
        agent.SetSteering(GetSteering());
    }

}
