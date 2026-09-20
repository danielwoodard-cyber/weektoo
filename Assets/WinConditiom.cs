using UnityEngine;

public class WinConditiom : MonoBehaviour
{
    public Transform player;
    public Transform cube;
    private float winDistance = 1.5f;

    private bool hasWon = false;
    private string distance;

    // Update is called once per frame
    void Update()
    {
        if (hasWon) return;

        float distance = Vector3.Distance(player.position, cube.position);
        
        if (distance <= winDistance)
        {
            hasWon = true;
            WinGame();
        }


    }
    void WinGame()
    {
        Debug.Log("Congrats!");
    }
}
