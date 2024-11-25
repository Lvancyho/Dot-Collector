using UnityEngine;

public class ColourChangeCommand : ICommand
{
    private readonly Color _colour; //what color to apply
    private readonly SpriteRenderer _target; //what to apply the color on

    public ColourChangeCommand(Color color, SpriteRenderer target)
    {
        _colour = color; //assigns the color
        _target = target; //assigns the target
    }

    public void Execute()
    {
        _target.color = _colour; //applys the colour
    }
}
