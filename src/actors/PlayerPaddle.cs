using Godot;
using System;

public partial class PlayerPaddle : CharacterBody2D
{
    [Export] public float Speed { get; set; } = 600.0f;

    public override void _PhysicsProcess(double delta)
    {

        Vector2 velocity = Velocity;

        float inputDirection = Input.GetAxis("ui_up", "ui_down");

        if (inputDirection != 0)
        {
            velocity.Y = inputDirection * Speed;
        }
        else
        {
            velocity.Y = 0;
        }
        velocity.X = 0;
        Velocity = velocity;
        MoveAndSlide();
    }
}