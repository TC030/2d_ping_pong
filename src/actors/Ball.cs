using Godot;
using System;

public partial class Ball : CharacterBody2D
{
	public const float Speed = 400.0f;
	private Vector2 _velocity;
	public override void _Ready()
	{
		_velocity = new Vector2(-1.0f, 0.5f).Normalized() * Speed;
	}
	public void ResetBall()
	{
		Vector2 CenterOfScreen = GetViewportRect().Size / 2;
		_velocity = new Vector2(1.0f, 0.5f).Normalized() * Speed;
		GlobalPosition = CenterOfScreen;
	}	
	public override void _PhysicsProcess(double delta)
	{
		var collisionInfo = MoveAndCollide(_velocity * (float)delta);

		if (collisionInfo != null)
		{
			_velocity = _velocity.Bounce(collisionInfo.GetNormal());
			GD.Print("Hit something!");
		}
	}
}
