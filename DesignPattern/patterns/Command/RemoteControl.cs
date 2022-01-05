namespace DesignPattern.patterns.Command
{
    public static class CommandPatternTest
    {
        public static void Test()
        {
            var remoteControlWithUndo = new RemoteControlWithUndo();
            var livingRoomLight = new Light("lv room");
            var lOn = new LightOnCommand(livingRoomLight);
            var lOff = new LightOffCommand(livingRoomLight);
            remoteControlWithUndo.SetCommand(0, lOn, lOff);
            remoteControlWithUndo.OnButtonWasPushed(0);
            remoteControlWithUndo.OffButtonWasPushed(0);
            remoteControlWithUndo.PrintToConsole();
            remoteControlWithUndo.UndoButtonWasPushed();
            remoteControlWithUndo.OffButtonWasPushed(0);
            remoteControlWithUndo.OnButtonWasPushed(0);
            remoteControlWithUndo.PrintToConsole();
            remoteControlWithUndo.UndoButtonWasPushed();
        }
    }
    //invoker
    public class RemoteControlWithUndo
    {
        private readonly Command[] _onCommand;
        private readonly Command[] _offCommand;
       
        private Command _undoCommand;

        public RemoteControlWithUndo()
        {
            _onCommand = new Command[7];
            _offCommand = new Command[7];
            var noCommand = new NoCommand();
            for (var i = 0; i < 7; i++)
            {
                _onCommand[i] = noCommand;
                _offCommand[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            _onCommand[slot] = onCommand;
            _offCommand[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommand[slot].Execute();
            _undoCommand = _onCommand[slot]; //记录命令
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommand[slot].Execute();
            _undoCommand = _onCommand[slot]; //记录命令
        }


        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }
    }

    public class Light
    {
        public Light(string name)
        {
            
        }
    }

    public class LightOffCommand : Command{
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }

        public override void Store()
        {
            throw new System.NotImplementedException();
        }

        public override void Undo()
        {
            throw new System.NotImplementedException();
        }

        public override void Load()
        {
            throw new System.NotImplementedException();
        }
    }
    public class LightOnCommand : Command
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }

        public override void Store()
        {
            throw new System.NotImplementedException();
        }

        public override void Undo()
        {
            throw new System.NotImplementedException();
        }

        public override void Load()
        {
            throw new System.NotImplementedException();
        }
    }
    //command and concrete command
    public class NoCommand : Command
    {
        public override void Execute()
        {
        }

        public override void Store()
        {
            throw new System.NotImplementedException();
        }

        public override void Undo()
        {
            throw new System.NotImplementedException();
        }

        public override void Load()
        {
            throw new System.NotImplementedException();
        }
    }
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Store();
        public abstract void Undo();
        public abstract void Load();
    }
}