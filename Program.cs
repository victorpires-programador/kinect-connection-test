using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;

namespace KinectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (KinectSensor.KinectSensors.Count > 0)
            {
                KinectSensor sensor = KinectSensor.KinectSensors[0];
                sensor.SkeletonStream.Enable();

                try
                {
                    sensor.Start();
                    Console.WriteLine("Kinect iniciado com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao iniciar Kinect: " + ex.Message);
                }

                Console.ReadKey();
                sensor.Stop();
            }
            else
            {
                Console.WriteLine("Nenhum Kinect encontrado.");
            }
        }
    }
}
