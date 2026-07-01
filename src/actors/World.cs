using Godot;
using System;

public partial class World : Node2D
{
	[Export] private Ball _ball;
	[Export] private Timer _timer;
	private bool _isNextLaunchLeft;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public void OnLeftGoalBodyEntered(Node2D body)
	{
		if (body is Ball)
		{
			_ball.ResetBall();
			_isNextLaunchLeft = true;
			GD.Print("Left Goal Scored!");
			_timer.Start();
		}
	}

	public void OnRightGoalBodyEntered(Node2D body)
	{
		if (body is Ball)
		{
			_ball.ResetBall();
			_isNextLaunchLeft = false;
			GD.Print("Right Goal Scored!");
			_timer.Start();
		}
	}

	public void OnTimerTimeout()
	{
		GD.Print("Timeout! Launching Ball");
		_ball.LaunchBall(_isNextLaunchLeft);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
