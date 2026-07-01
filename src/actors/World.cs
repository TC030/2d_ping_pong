using Godot;
using System;

public partial class World : Node2D
{
	[Export] private Ball _ball;
	[Export] private Timer _timer;
	[Export] private Label _countdownLabel;

	private bool _isNextLaunchLeft;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public void OnLeftGoalBodyEntered(Node2D body)
	{
		if (body is Ball)
		{
			_isNextLaunchLeft = true;
			GD.Print("Left Goal Scored!");
			OnGoalBodyEntered();
		}
	}

	public void OnRightGoalBodyEntered(Node2D body)
	{
		if (body is Ball)
		{
			_isNextLaunchLeft = false;
			GD.Print("Right Goal Scored!");
			OnGoalBodyEntered();
		}
	}

	private void OnGoalBodyEntered()
	{
		_ball.ResetBall();
		_timer.Start();
		_countdownLabel.Visible = true;
	}

	public void OnTimerTimeout()
	{
		GD.Print("Timeout! Launching Ball");
		_ball.LaunchBall(_isNextLaunchLeft);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (!_timer.IsStopped())
		{
			_countdownLabel.Text = Math.Ceiling(_timer.TimeLeft).ToString();
		}
		else
		{
			_countdownLabel.Visible = false;
		}
	}
}
