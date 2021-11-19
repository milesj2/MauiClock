using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;
using System.Threading;

namespace MauiClock.Controls;

public partial class DigitalClockControl
{

    private Timer timeUpdateTimer;

    public DigitalClockControl()
    {
        InitializeComponent();
        InitTimer();
    }

    public void InitTimer()
    {

        timeUpdateTimer = new Timer(
            new TimerCallback(TimerCallback),
            null,
            500,
            500
        );

    }

    private void TimerCallback(object state)
    {
        Application.Current.Dispatcher.BeginInvokeOnMainThread(() => 
        {
            lblTime.Text = $"{DateTime.Now.ToString("HH:mm:ss")}";
            lblDate.Text = $"{DateTime.Now.ToString("ddd, MMM dd")}";
        });

    }



}
