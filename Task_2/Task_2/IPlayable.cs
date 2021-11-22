using System;


namespace Task_2
{
     interface IPlayable : IMedia
    {
        void Play();
        void Pause();
        void Stop();
    }
}
