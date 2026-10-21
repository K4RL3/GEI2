using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class puntero : MonoBehaviour
{
    public RectTransform monedaTransform;
    public RectTransform limaTransform;
    public GameObject[] ImgMouse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monedaTransform.position = Mouse.current.position.ReadValue();
        limaTransform.position = Mouse.current.position.ReadValue();
    }

    public void CambiarPuntero(GameObject imagen)
    {
        imagen.SetActive(true);
        Cursor.visible = false;
    }

    public void QuitarIng()
    {
        for (int i = 0; i < ImgMouse.Length; i++)
        {
            ImgMouse[i].gameObject.SetActive(false);
        }
        Cursor.visible = true;
    }
}
