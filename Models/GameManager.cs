using FlapppBirdDemo.Web.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FlapppBirdDemo.Web.Models
{
    public class GameManager
    {
        private readonly int _gravity = 2;
        public event EventHandler MainLoopCompleted;
        public BirdModel Bird { get; private set; }
        public List<PipeModel> Pipes { get; private set; }
        public bool IsRunning { get; private set; } = false;

        public GameManager()
        {
            Bird = new BirdModel();
            Pipes = new List<PipeModel>();
        }

        public async void MainLoop()
        {
            IsRunning = true;
            while(IsRunning)
            {
                MoveObjects();
                CheckForCollisions();
                ManagePipes();

                MainLoopCompleted?.Invoke(this, EventArgs.Empty);      
                await Task.Delay(20);
            }
        }

        public void StartGame()
        {
            if (!IsRunning)
            {
                Bird = new BirdModel();
                Pipes = new List<PipeModel>();
                MainLoop();
            }
        }

        public void Jump()
        {
            if (IsRunning)
                Bird.Jump();
        }

        void CheckForCollisions()
        {
            if (Bird.IsONGround())
                GameOver();

            // if pipe in thw middle
            var ceneterdPipe = Pipes.FirstOrDefault(p => p.IsCenterd());

            // check collision with
            if (ceneterdPipe != null)
            {
                bool hasCollidedWithBottom = Bird.DistanceFromGround < ceneterdPipe.GapBottom - 150;
                bool hasCollidedWithTup = Bird.DistanceFromGround + 45> ceneterdPipe.GapTop - 150;

                if (hasCollidedWithBottom || hasCollidedWithTup)
                    GameOver();
            }
        }

        void ManagePipes()
        {
            if (!Pipes.Any() || Pipes.Last().DistanceFromLeft <= 250)
                Pipes.Add(new PipeModel());

            if (Pipes.First().IsOffScreen())
                Pipes.Remove(Pipes.First());
        }

        void MoveObjects()
        {
            Bird.Fall(_gravity);
            foreach (var pipe in Pipes) {
                pipe.Move();
            }
        }

        void GameOver()
        {
            IsRunning = false;    
        }

    }
}
