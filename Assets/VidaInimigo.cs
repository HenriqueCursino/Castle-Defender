using UnityEngine;

public class VidaInimigo : MonoBehaviour
{
    public int hp;

    public void ReceberDano(int dano)
    {
        hp -= dano;

        if (hp <= 0)
        {
            Morrer();
        }
    }

    private void Morrer()
    {
        // Aqui você pode colocar animação, som, partículas etc.
        Destroy(gameObject);
    }
}
