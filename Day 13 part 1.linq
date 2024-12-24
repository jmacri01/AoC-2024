<Query Kind="Program" />

void Main()
{
	var input = @"Button A: X+5, Y+5
Button B: X+4, Y+4
Prize: X=25, Y=25

Button A: X+26, Y+66
Button B: X+67, Y+21
Prize: X=12748, Y=12176

Button A: X+17, Y+86
Button B: X+84, Y+37
Prize: X=7870, Y=6450

Button A: X+69, Y+23
Button B: X+27, Y+71
Prize: X=18641, Y=10279".Split(Environment.NewLine);
	
	var machines = new List<MachineInfo>();

	var machineInfo = new MachineInfo
	{
		Buttons = new List<ButtonInfo>(),
	};

	for (var i = 0; i < input.Length - 2; i += 4)
	{
		var prizeRegex = new Regex(@"X\=(\d+)\,\sY\=(\d+)");
		var machine = new MachineInfo
		{
			Buttons = new List<ButtonInfo>(),
			PrizeLocation = (int.Parse(prizeRegex.Match(input[i + 2]).Groups[1].Captures[0].Value), int.Parse(prizeRegex.Match(input[i + 2]).Groups[2].Captures[0].Value)),
		};
		
		var buttonRegex = new Regex(@"X\+(\d+)\,\sY\+(\d+)");
		machine.Buttons.Add(new ButtonInfo
		{
			XMovement = int.Parse(buttonRegex.Match(input[i]).Groups[1].Captures[0].Value),
			YMovement = int.Parse(buttonRegex.Match(input[i]).Groups[2].Captures[0].Value),
			Cost = 3,
		});
		
		machine.Buttons.Add(new ButtonInfo
		{
			XMovement = int.Parse(buttonRegex.Match(input[i + 1]).Groups[1].Captures[0].Value),
			YMovement = int.Parse(buttonRegex.Match(input[i + 1]).Groups[2].Captures[0].Value),
			Cost = 1,
		});		
		machines.Add(machine);
	}
	
	var simulator = new MachinePlaySimulator();
	
	foreach(var machine in machines)
	{
		var finalStates = simulator.SimulateWin(machine, 100);
		finalStates.Dump();
		break;
	}
	
}

public class MachinePlaySimulator
{
	public PlayStateInfo SimulateWin(MachineInfo machineInfo, int numTurns)
	{
		var initialState = new PlayStateInfo
		{
			MachineInfo = machineInfo,
			ClawLocation = (0, 0),
		};
		
		return SimulateWin(initialState, numTurns);
	}
	
	public PlayStateInfo SimulateWin(PlayStateInfo currentState, int numTurnsLeft)
	{
		if (numTurnsLeft <= 0 || currentState.IsWin || currentState.IsLoss)
		{
			return currentState;
		}

		var endStates = new List<PlayStateInfo>();
		
		foreach (var button in currentState.MachineInfo.Buttons)
		{
			var newState = new PlayStateInfo
			{
				ButtonPressed = button,
				MachineInfo = currentState.MachineInfo,
				ClawLocation = (currentState.ClawLocation.X + button.XMovement, currentState.ClawLocation.Y + button.YMovement),
				TotalCost = button.Cost + currentState.TotalCost,
			};
			
			endStates.Add(SimulateWin(newState, numTurnsLeft - 1));
		}
		
		return endStates.OrderByDescending(x => x.IsWin).ThenBy(x => x.TotalCost).FirstOrDefault();
	}
}

public class PlayStateInfo
{
	public MachineInfo MachineInfo { get; set; }
	public ButtonInfo ButtonPressed { get; set; }
	public (int X, int Y) ClawLocation { get; set; }
	public bool IsWin => ClawLocation == MachineInfo.PrizeLocation;
	public bool IsLoss => ClawLocation.X > MachineInfo.PrizeLocation.X || ClawLocation.Y > MachineInfo.PrizeLocation.Y;
	public int TotalCost { get; set; }
}

public class MachineInfo
{
	public List<ButtonInfo> Buttons { get; set; }
	public (int X, int Y) PrizeLocation { get; set; }
}

public class ButtonInfo
{
	public int XMovement { get; set;}
	public int YMovement { get; set;}
	public int Cost { get; set; }
}
