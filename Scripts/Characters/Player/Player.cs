using Godot;
using System;

public partial class Player : CharacterBody3D
{
	// variables
	private Vector2 _inputDirection = new();
	
	//exported variables
	[Export]
	private float _speed = 5.0f;
	
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}

    public override void _PhysicsProcess(double delta)
    {
        Velocity = new( _inputDirection.X, 0, _inputDirection.Y );
		Velocity *= _speed;
		MoveAndSlide();
    }

    public override void _Input(InputEvent @event)
    {
		_inputDirection = Input.GetVector("MoveLeft", "MoveRight", "MoveForward", "MoveBack");       
    }
}
