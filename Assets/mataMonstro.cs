using UnityEngine;

public class MataMonstro : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;
        int dano = 0;

        switch (tag)
        {
            case "Esqueleto":
                dano = 1; 
                // Esqueleto morre com 1 golpe
                break;

            case "Lagarto":
                dano = 1; 
                // Lagarto tem HP 2 → precisa de 2 golpes (dano 1 por hit)
                break;

            case "Golem":
                dano = 1; 
                // Golem tem HP 3 → precisa de 3 golpes (dano 1 por hit)
                break;

            default:
                return;
        }

        VidaInimigo vida = other.GetComponent<VidaInimigo>();

        if (vida != null)
        {
            vida.ReceberDano(dano);
        }
    }
}
