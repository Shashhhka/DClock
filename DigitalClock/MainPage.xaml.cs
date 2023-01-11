using System.Timers;

namespace DigitalClock;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        var timer = new System.Timers.Timer(1000);
        timer.Elapsed += new ElapsedEventHandler(RedrawClock);
        timer.Start();
    }

    public void RedrawClock(object Source, ElapsedEventArgs e)
    {
        var graphicsView = this.ClockGraphicsView;
        graphicsView.Invalidate();
    }
}


