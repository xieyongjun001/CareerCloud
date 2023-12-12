using System;
namespace DockerDemo
{
    public delegate void AlarmEventHandler(object source, AlarmEventArgs args);

    public class AlarmEventArgs : EventArgs
    {
        public DateTime AlarmTime { get; set; }

        public AlarmEventArgs(DateTime alarmTime)
        {
            AlarmTime = alarmTime;
        }
    }


    
}

