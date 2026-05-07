using UnityEngine;

public class StarterScript : MonoBehaviour
{
    [SerializeField] bool door = true;
    [SerializeField] GameObject myGate;
    void Start()
    {

    }

    void Update()
    {
        if (door)
        {
            myGate.SetActive(true);
        }
        else
        {
            myGate.SetActive(false);
        }
    }
}
