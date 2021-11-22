using System;


namespace Task_2
{
    public class PlayerItem
    {
        public IMedia MediaFile { get; }
        public PlayerItem(IMedia file)
        {
            MediaFile = file;
        }
        public void PrintProperties()
        {
            Console.Write($"File \"{MediaFile.FileName}\": ");

            if (MediaFile is IPlayable)
                Console.Write("Play(), ");

            if (MediaFile is IRecordable)
                Console.Write("Record(), ");

            Console.WriteLine("Pause(), Stop()");
        }
    }
}
