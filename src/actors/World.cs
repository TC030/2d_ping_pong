using Godot;
using System;

public partial class World : Node2D
{
	[Export] private Ball _ball;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public void OnLeftGoalBodyEntered(Node2D body)
	{
		if (body is Ball)
		{
			_ball.ResetBall(isLeftPlayerLost: true);
			GD.Print("Left Goal Scored!");
		}
	}

	public void OnRightGoalBodyEntered(Node2D body)
	{
		if (body is Ball)
		{
			_ball.ResetBall(isLeftPlayerLost: false);
			GD.Print("Right Goal Scored!");
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
