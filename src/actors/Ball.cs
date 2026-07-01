using Godot;
using System;

public partial class Ball : CharacterBody2D
{
	public const float Speed = 40.0f;
	private Vector2 _velocity;
	public override void _Ready()
	{
		_velocity = new Vector2(1.0f, 1.5f).Normalized() * Speed;
	}

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = _velocity;

		var collisionInfo = MoveAndCollide(velocity * (float)delta);

		if (collisionInfo != null)
		{
			_velocity = _velocity.Bounce(collisionInfo.GetNormal());
			GD.Print("Hit something!");
		}
	}
}
