using UnityEngine;
using UnityEngine.InputSystem;

public class PrepararHotDog : MonoBehaviour
{
    public GameObject MonedaPrefab;
    public GameObject LimaPrefab;
    int ingActual;

    Camera camera;
    float contador;
    float contadorIng;

    public puntero puntero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = Camera.main;
        contador = 0;
        contadorIng = 0;

        ingActual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (ingActual) 
        { 
        case 0:// nada

            break;
        case 1:
            if (Mouse.current.leftButton.isPressed)
            {
                contador += Time.deltaTime;
                    if (contador < 1.5f)
                    {
                        contadorIng += Time.deltaTime;
                        if (contadorIng > 0.1f)
                        {
                            contadorIng = 0;
                            Ray ray = camera.ScreenPointToRay(Mouse.current.position.ReadValue());
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                            {
                                Instantiate(MonedaPrefab, hit.point, Quaternion.identity);
                            }
                        }
                    }
                    else 
                    {
                        puntero.QuitarIng();
                    }
                  
            }
            break;
            case 2:
            if (Mouse.current.leftButton.isPressed)
            {
                contador += Time.deltaTime;
                    if (contador < 1.5f)
                    {
                        contadorIng += Time.deltaTime;
                        if (contadorIng > 0.1f)
                        {
                            contadorIng = 0;
                            Ray ray = camera.ScreenPointToRay(Mouse.current.position.ReadValue());
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                            {
                                Instantiate(LimaPrefab, hit.point, Quaternion.identity);
                            }
                        }
                    }
                    else 
                    {
                        puntero.QuitarIng();
                    }
                  
            }
            break;
        }
    }
    public void CambiarIng( int numero)
    {
        contador = 0;
        ingActual = numero;
    }
}
