using Godot;
using System;

public partial class Ball : CharacterBody2D
{
	public const float Speed = 400.0f;
	private Vector2 _velocity;
	private RandomNumberGenerator _rng = new RandomNumberGenerator();
	public override void _Ready()
	{
		_rng.Randomize();
		_velocity = new Vector2(-1.0f, 0.5f).Normalized() * Speed;
	}
	private void LaunchBall(bool isMovingLeft)
	{
		float randomAngle = _rng.RandfRange(-Mathf.DegToRad(30), Mathf.DegToRad(30));
		Vector2 baseDirection = isMovingLeft ? Vector2.Left: Vector2.Right;
		_velocity = baseDirection.Rotated(randomAngle) * Speed;
	}
	public void ResetBall(bool isLeftPlayerLost)
	{
		Vector2 CenterOfScreen = GetViewportRect().Size / 2;
		GlobalPosition = CenterOfScreen;
		LaunchBall(isMovingLeft: isLeftPlayerLost);
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
