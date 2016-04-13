using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Simple Implementation of Dependency Injection using 
//1. Constructor (takes Interface Instance), 
//2. Set Property (Insert set property for Interface and 
//3. Method (takes Interface instance)

//Implementing  DI using Constructor

//namespace DemoInterfaces
//{
//    public interface IService
//    {
//        void Serve();
//    }

//    public class Service : IService
//    {
//        public void Serve()
//        {
//            Console.WriteLine("Service Called");
//            //To Do: Some Stuff
//        }
//    }

//    public class Client
//    {
//        private IService _service;


//        //Constructor DI taking object of Interface
//        public Client(IService service)
//        {
//            this._service = service;
//        }

//        public void Start()
//        {
//            Console.WriteLine("Service Started");
//            this._service.Serve();
//            //To Do: Some Stuff
//        }
//    }

//    class Program2
//    {
//       public static void Main(string[] args)
//        {
//            Client client = new Client(new Service());
//            client.Start();

//            Console.ReadKey();
//        }
//    }
//}






//Property injection. Also called Setter injection.
//namespace DemoInterfaces
//{


//    public interface IService
//    {
//        void Serve();
//    }

//    public class Service : IService
//    {
//        public void Serve()
//        {
//            Console.WriteLine("Service Called");
//            //To Do: Some Stuff
//        }
//    }

//    public class Client
//    {
//        private IService _service;

//  Here we created a property as setter for interface        
//        public IService Service
//        {
//            set
//            {
//                this._service = value;
//            }
//        }

//        public void Start()
//        {
//            Console.WriteLine("Service Started");
//            this._service.Serve();
//            //To Do: Some Stuff
//        }
//    }
//    class Program2
//    {
//        static void Main(string[] args)
//        {
//            Client client = new Client();
//            client.Service = new Service();
//            client.Start();

//            Console.ReadKey();
//        }
//    }

//}


//namespace DemoInterfaces
//{
//    //Method injection DI
//    public interface IService
//    {
//        void Serve();
//    }

//    public class Service : IService
//    {
//        public void Serve()
//        {
//            Console.WriteLine("Service Called");
//            //To Do: Some Stuff
//        }
//    }

//    public class Client
//    {
//        private IService _service;


//        //Method start takes instance of Interface as Argument
//        public void Start(IService service)
//        {
//            this._service = service;
//            Console.WriteLine("Service Started");
//            this._service.Serve();
//            //To Do: Some Stuff
//        }
//    }
//    class Program2
//    {
//        static void Main(string[] args)
//        {
//            Client client = new Client();
//            client.Start(new Service());

//            Console.ReadKey();
//        }
//    }

//}
