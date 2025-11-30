namespace Task2.My_Controller
{
    public class ApiClientFlex
    {
        private API_Controller _controller = new API_Controller();

        public void FlaxiOperation()
        {
            Console.WriteLine(_controller.GetByFilter());
            Console.WriteLine(_controller.DeleteMany());
            Console.WriteLine(_controller.Print());
            Console.WriteLine(_controller.PrintMany());
            Console.WriteLine(_controller.SetStatus());
            Console.WriteLine(_controller.Deactivate());
            Console.WriteLine(_controller.Activate());
        }
    }
}
