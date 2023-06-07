using System;

namespace BookRecipe.Services
{
    public class MusicPlayerService
    {
        public void Play()
        {
            // Код для воспроизведения музыки
            Console.WriteLine("Музыка начинает играть.");
        }

        public void Pause()
        {
            // Код для приостановки воспроизведения музыки
            Console.WriteLine("Музыка приостановлена.");
        }

        public void Stop()
        {
            // Код для остановки воспроизведения музыки
            Console.WriteLine("Музыка остановлена.");
        }
    }
}