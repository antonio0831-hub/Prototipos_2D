using Unity.VisualScripting;
using UnityEngine;

public class MovementTutorial : MonoBehaviour
{
    [SerializeField] private GameObject tutorialPanel;
    private bool activePanel = false;
    private float counter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        activePanel = true;
        ShowTutorial();
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 3f)
        {
            activePanel=false;
            Destroy(tutorialPanel);
        }
    }
    void ShowTutorial()
    {
        tutorialPanel.SetActive(activePanel);
    }
}
