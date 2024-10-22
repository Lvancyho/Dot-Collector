using UnityEngine;
using UnityEngine.UI;

public class PlayerColorChanger : MonoBehaviour
{
    public Button redButton;
    public Button yellowButton;
    public Button blueButton;
    public SpriteRenderer playerRenderer;

    //makes it so buttons change player color

    // Start is called before the first frame update
    void Start()
    {
        // Add listeners for the buttons
        redButton.onClick.AddListener(SetRedColor);
        yellowButton.onClick.AddListener(SetYellowColor);
        blueButton.onClick.AddListener(SetBlueColor);
    }

    // change to red
    void SetRedColor()
    {
        playerRenderer.color = Color.red;
    }

    // change to yellow
    void SetYellowColor()
    {
        playerRenderer.color = Color.yellow;
    }

    // change to blue
    void SetBlueColor()
    {
        playerRenderer.color = Color.blue;
    }
}
