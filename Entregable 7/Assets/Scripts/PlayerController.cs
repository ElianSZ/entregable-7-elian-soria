using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI textMessage;

    void Start()
    {
        textMessage.text = "Pulsa cualquiera de las cuatro flechas";        // Al empezar el juego muestra este mensaje
    }

    void Update()
    {
        // Se actualiza la función ShowMessage en los parámetros correspondientes
        ShowMessage(KeyCode.LeftArrow, textMessage.text);
        ShowMessage(KeyCode.RightArrow, textMessage.text);
        ShowMessage(KeyCode.UpArrow, textMessage.text);
        ShowMessage(KeyCode.DownArrow, textMessage.text);
        ShowMessage(KeyCode.X, textMessage.text);
    }

    public void ShowMessage(KeyCode key, string message)                    // Función que comprueba que al pulsar una de esas teclas nos muestra el texto correspondiente
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))                            // Al pulsar la flecha izquierda, nos muestra este texto
        {
            textMessage.text = "Izquierda";
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))                           // Al pulsar la flecha derecha, nos muestra este texto
        {
            textMessage.text = "Derecha";
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))                              // Al pulsar la flecha de arriba, nos muestra este texto
        {
            textMessage.text = "Arriba";
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))                            // Al pulsar la flecha de abajo, nos muestra este texto
        {
            textMessage.text = "Abajo";
        }

        if (Input.GetKeyDown(KeyCode.X))                                    // Al pulsar la tecla X, nos muestra este texto
        {
            textMessage.text = "Pium!";
        }
    }
}
