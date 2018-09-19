using System;
namespace test
{
    public class SpeedCamera
    {
        float SpeedLimit;
        int DemeritPoints;
        float CarSpeed;

        public SpeedCamera(float limit)
        {
            SpeedLimit = limit;
        }

        public void Penalize(float exceededValue)
        {
            DemeritPoints += (int)(exceededValue / 5.0);

        }

        public void AnalyzeLicense()
        {
            Console.WriteLine(DemeritPoints > 12 ? "License Suspended" : "");
        }

        public void IncreaseSpeed(float speed) 
        {
            CarSpeed = speed;
            if (CarSpeed <= SpeedLimit)
            {
                Console.WriteLine("OK");
                return;

            }
            Penalize(CarSpeed - SpeedLimit);
            AnalyzeLicense();
        }

    }
}
