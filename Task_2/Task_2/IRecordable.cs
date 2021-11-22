using System;


namespace Task_2
{
     interface IRecordable : IMedia
    {
        void Record();
        void Pause();
        void Stop();
    }
}
