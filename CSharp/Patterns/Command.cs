using System;

public class Controls : IControls
{
    private int _volume = 25;
    private int _channel = 12;

/*
    public int Volume
    {
        get { return _volume; }
        set { _volume = value; }
    }

    public int Channel
    {
        get { return _channel; }
        set { _channel = value; }
    }*/
    
    public void Volume(bool vol)
    {
        if(vol)
        {
            _volume++;
        }
        else
        {
            _volume--;
        }

        VolumeDisplay();
    }

    private void VolumeDisplay()
    {
        Console.WriteLine("Volume now is " + _volume);
    }

    private void ChannelDisplay()
    {
        Console.WriteLine("Channel now is " + _channel);
    }

    public void Volume(int vol)
    {
        if(vol < 100)
        {
            _volume = vol;
            VolumeDisplay();
        }
        else
        {
            Console.WriteLine("Volume should be less than 100!");
        }
    }

    public void Channel(bool vol)
    {
        if(vol)
        {
            _volume++;
        }
        else
        {
            _volume--;
        }

        ChannelDisplay();
    }

    public void Channel(int cha)
    {
        if(cha < 1000)
        {
            _channel = cha;
            ChannelDisplay();
        }
        else
        {
            Console.WriteLine("Channel should be less than 1000!");
        }
    }
}

public interface IControls
{

    public void Volume(bool vol);
    public void Channel(bool vol);
    public void Volume(int vol);
    public void Channel(int vole);
}

public class Remote
{
    private readonly IControls _controls;

    public Remote(IControls controls)
    {
        _controls = controls;
    }

    public void VolumeUp()
    {
        _controls.Volume(true);
    }

    public void VolumeDown()
    {
        _controls.Volume(false);
    }

    public void ChannelSet(int no)
    {
        _controls.Channel(no);
    }
}

public partial class Program
{
    public static void Main()
    {
        IControls controls = new Controls();
        var remote = new Remote(controls);

        remote.ChannelSet(1002);

        remote.ChannelSet(800);

        remote.VolumeUp();
    }
}