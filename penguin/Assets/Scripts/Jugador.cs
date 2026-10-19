using UnityEngine;
using UnityEngine.AI;

public class Jugador : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animator;
    public Color color;

    public MeshRenderer[] piezasPiel;
    public MeshRenderer ojoRender;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        animator = this.transform.GetChild(0).GetChild(0).GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(this.transform.position, agent.destination) < 0.2f)
        {
            if (animator.GetInteger("Estado" )!= 2) 
            {
                animator.SetInteger("Estado", 0);
            }
            
        }

        /*float h,s,v;

        Color.RGBToHSV(color, out h, out s, out v);

        h += 1 *Time.deltaTime;
        if(h > 1)
        {
            h -= 1;
        }

        color = Color.HSVToRGB(h, s, v);*/
        AsignarColor(color);
    }

    public void AsignarDestino(Vector3 destinto)
    {
        agent.SetDestination(destinto);
        animator.SetInteger("Estado", 1);
    }

    public void AsignarColor(Color color)
    {
        for (int i = 0; i < piezasPiel.Length; i++)
        {
            piezasPiel[i].material.color = color;
        }
        ojoRender.materials[1].color = color;
    }

    public void Bailar()
    {
        animator.SetInteger("Estado", 2);
    }
}
