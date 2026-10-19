using UnityEngine;
using UnityEngine.AI;

public class Jugador : MonoBehaviour
{
    NavMeshAgent agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AsignarDestino(Vector3 destinto)
    {
        agent.SetDestination(destinto);
    }
}
