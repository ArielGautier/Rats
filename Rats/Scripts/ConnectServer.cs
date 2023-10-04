using Godot;
using System;
using System.Net;
using System.Net.Sockets;

public partial class ConnectServer : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private TcpClient client;

	private int port = 2222;
	private string IP = " ";
	
	private void _on_button_down()
	{
		IP = "localhost";
		client = new TcpClient();
		try
		{
			client.Connect(IP, port);
		}

		catch (Exception ex)
		{
			GD.Print("Error : " + ex.Message);
		}

		if (client.Connected)
		{
			GD.Print("Connected");
			//GD.Print((MethodInvoker)delegate { textBox3.Text = "Connected..."; });

		}
	}
}
