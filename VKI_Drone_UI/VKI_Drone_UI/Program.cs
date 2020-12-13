using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKI_Drone_UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            var drone = new Drone();
            var signal = new Mail { Adres = "random1@gmail.com" };
            var signal2 = new Mail { Adres = "random2@gmail.com" };

            /****************************************************************/
            drone.AddObserver(signal);
            drone.AddObserver(signal2);

            drone.AddOrder("Signal:", "Active mode");

            drone.RemoveObserver(signal2);

            drone.AddOrder("Signal2:", "Error mode");
            /****************************************************************/
            var order = new Mail { Adres = "random1@gmail.com" };
            var order2 = new Mail { Adres = "random2@gmail.com" };

            drone.AddObserver(order);
            drone.AddObserver(order2);

            drone.AddOrder("Order:", "Chocolate");

            drone.RemoveObserver(order2);

            drone.AddOrder("Order2:", "Ham");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Console.ReadKey();
        }
    }

    static class Data
    {
        public static string Signal { get; set; }
        public static string Order { get; set; }
    }

    interface IObservable
    {
        void AddObserver(IObserver obs);

        void RemoveObserver(IObserver obs);

        void NotifyObservers(object data);
    }

    class Drone : IObservable
    {
        private List<IObserver> observers;

        public Drone()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            observers.Remove(obs);
        }

        public void NotifyObservers(object data)
        {
            foreach (IObserver observer in observers)
                observer.Update(data);
        }

        public void AddOrder(string title, string text)
        {
            var signal = $"{title} : {text}";
            NotifyObservers(signal);
        }
    }

    interface IObserver
    {
        void Update(object data);
    }

    class Mail : IObserver
    {
        public string Adres { get; set; }

        public void Update(object data)
        {

            Data.Order = (data.ToString() + " sent on " + Adres.ToString());

            
            Data.Signal = (data.ToString() + " sent on " + Adres.ToString());
            
                
            //Console.WriteLine(data + " sent on " + Adres);
        }

    }
}
