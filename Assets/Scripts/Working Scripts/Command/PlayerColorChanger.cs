using UnityEngine;
using UnityEngine.UI;

public class PlayerColorChanger : MonoBehaviour
{
    public Button redButton;
    public Button yellowButton;
    public Button blueButton;
    public SpriteRenderer playerRenderer;

    private ICommand redCommand;
    private ICommand yellowCommand;
    private ICommand blueCommand;

    void Start()
    {
        // Initialize commands
        redCommand = new ColourChangeCommand(Color.red, playerRenderer);
        yellowCommand = new ColourChangeCommand(Color.yellow, playerRenderer);
        blueCommand = new ColourChangeCommand(Color.blue, playerRenderer);

        // Add listeners for buttons
        redButton.onClick.AddListener(() => ExecuteCommand(redCommand));
        yellowButton.onClick.AddListener(() => ExecuteCommand(yellowCommand));
        blueButton.onClick.AddListener(() => ExecuteCommand(blueCommand));
    }

    void ExecuteCommand(ICommand command)
    {
        command.Execute();
    }
}
