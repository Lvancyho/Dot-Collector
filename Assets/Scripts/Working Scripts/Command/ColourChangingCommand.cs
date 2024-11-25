using UnityEngine;

public class ColourChangeCommand : ICommand
{
    private readonly Color _color;
    private readonly SpriteRenderer _target;

    public ColourChangeCommand(Color color, SpriteRenderer target)
    {
        _color = color;
        _target = target;
    }

    public void Execute()
    {
        _target.color = _color;
    }
}
