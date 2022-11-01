using Godot;
using System;

public class Floatie : Node2D
{
    private Sprite FloatieSprite;
    RandomNumberGenerator Rnd = new RandomNumberGenerator();
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Rnd.Randomize();
        FloatieSprite = GetNode<Sprite>("Sprite");
    }
    public void RandomizeSpritePosition()
    {
       int randX = (int)Rnd.RandiRange(-10,10);
       int randY = (int)Rnd.RandiRange(-10,10);
       Vector2 randPos = new Vector2(randX,randY);
       FloatieSprite.Position += randPos;
    }
}
