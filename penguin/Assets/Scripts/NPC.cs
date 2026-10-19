using UnityEngine;

public class NPC : MonoBehaviour
{
    Jugador jugador;
    float contador;
    int estado;

    Vector3 destino;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jugador = this.GetComponent<Jugador>();
        contador = 0;
        estado = 0;
        destino = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        switch(estado)
        {
            case 0: // esperar a moverse
                contador += Time.deltaTime;
                if (contador > 1)
                {
                    contador = 0;
                    estado = 1 ;
                    destino = new Vector3(
                        Random.Range(-4, 4),
                        0,
                        Random.Range(-4, 4)
                        );
                    jugador.AsignarDestino(destino);
                }
                break;
            case 1: //si llega descansa
                if(Vector3.Distance(this.transform.position, destino) < 2)
                { 
                    estado = 2;
                }
                break;
            case 2:
                contador += Time.deltaTime;
                if (contador > 1)
                {
                    contador = 0;
                    estado = 0;
                }
                break;
        }
    }
}
