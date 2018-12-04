namespace GON.TelloController
{
    using UnityEngine;
    using System.Net.Sockets;
    using System.Text;

    public static class Controller
    {
        private static string host = "192.168.10.1";
        private static int port = 8889;
        private static UdpClient client = new UdpClient();

        public static int MoveSpeed = 1;

        /// <summary>
        /// UDP初期化
        /// </summary>
        public static void Initialize()
        {
            client.Connect(host, port);
        }

        /// <summary>
        /// Telloに接続
        /// </summary>
        public static void Connect()
        {
            byte[] dgram = Encoding.UTF8.GetBytes("command");
            client.Send(dgram, dgram.Length);
            Debug.Log("entry SDK mode");
        }

        public static void TakeOff()
        {
            byte[] dgram = Encoding.UTF8.GetBytes("takeoff");
            client.Send(dgram, dgram.Length);
            Debug.Log("Tello auto takeoff");
        }

        public static void Land()
        {
            byte[] dgram = Encoding.UTF8.GetBytes("land");
            client.Send(dgram, dgram.Length);
            Debug.Log("Tello auto land");
        }

        public static void EmergencyStop()
        {
            byte[] dgram = Encoding.UTF8.GetBytes("emergency");
            client.Send(dgram, dgram.Length);
            Debug.Log("Stop all motors immediately");
        }

        public static void Forward(int? speed = null)
        {
            speed = CheckSpeed(speed);

            byte[] dgram = Encoding.UTF8.GetBytes("rc 0 " + (-speed).ToString() + " 0 0");
            client.Send(dgram, dgram.Length);
            Debug.Log("move foward");
        }

        public static void Backward(int? speed = null)
        {
            speed = CheckSpeed(speed);

            byte[] dgram = Encoding.UTF8.GetBytes("rc 0 " + (speed).ToString() + " 0 0");
            client.Send(dgram, dgram.Length);
            Debug.Log("move backward");
        }

        public static void Left(int? speed = null)
        {
            speed = CheckSpeed(speed);

            byte[] dgram = Encoding.UTF8.GetBytes("rc " + (-speed).ToString() + " 0 0 0");
            client.Send(dgram, dgram.Length);
            Debug.Log("move left");
        }

        public static void Right(int? speed = null)
        {
            speed = CheckSpeed(speed);

            byte[] dgram = Encoding.UTF8.GetBytes("rc " + (speed).ToString() + " 0 0 0");
            client.Send(dgram, dgram.Length);
            Debug.Log("move right");
        }

        public static void Up(int? speed = null)
        {
            speed = CheckSpeed(speed);

            byte[] dgram = Encoding.UTF8.GetBytes("rc 0 0 " + (-speed).ToString() + " 0");
            client.Send(dgram, dgram.Length);
            Debug.Log("move up");
        }

        public static void Down(int? speed = null)
        {
            speed = CheckSpeed(speed);

            byte[] dgram = Encoding.UTF8.GetBytes("rc 0 0 " + (speed).ToString() + " 0");
            client.Send(dgram, dgram.Length);
            Debug.Log("move down");
        }

        private static int CheckSpeed(int? speed)
        {
            if (speed == null)
            {
                speed = MoveSpeed;
            }

            if (speed < -100)
            {
                speed = -100;
            }

            if (speed > 100)
            {
                speed = 100;
            }

            return (int)speed;

        }
    }
}



