using System;

namespace CarLibrary
{
    //engine state
    public enum EngineState
    { engineAlive, engineDead}

    //Abstract base class
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        protected EngineState egnState = EngineState.engineAlive;
        public EngineState EngineState => egnState;
        public abstract void TurboBoost();
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }
    }
}
