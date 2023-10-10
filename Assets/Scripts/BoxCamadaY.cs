using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCamada : MonoBehaviour
{
    public Transform player; // Arraste o objeto "Player" aqui na interface do Unity
    private Renderer boxRenderer;

    private void Start()
    {
        boxRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (player.transform.position.y < transform.position.y)
        {
            // Se o objeto "Player" estiver abaixo do objeto "Box" no eixo Y
            boxRenderer.sortingOrder = -1; // Define a ordem na camada para -1
        }
        else
        {
            // Se o objeto "Player" estiver acima do objeto "Box" no eixo Y
            boxRenderer.sortingOrder = 1; // Define a ordem na camada para 1
        }
    }
}
