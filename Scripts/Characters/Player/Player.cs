using Godot;
using System;

public partial class Player : CharacterBody3D
{
	// node references
	private Sprite3D _playerSpriteNode;
	private AnimationPlayer _playerAnimNode;
	// variables
	private Vector2 _inputDirection = new();
	
	//exported variables
	[ExportGroup("character variables")]
	[Export]
	private float _speed = 5.0f;
	
	public override void _Ready()
	{
		_playerSpriteNode = GD.Load<Sprite3D>("PlayerSprite");
		_playerAnimNode = GD.Load<AnimationPlayer>("PlayerAnimation");
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
