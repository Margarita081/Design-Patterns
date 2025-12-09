namespace Task2.My_Controller
{
    public class CrudApiClient
    {
        private APIController _controller = new APIController();

        public void CrudOperation()
        {
            Console.WriteLine(_controller.Create());
            Console.WriteLine(_controller.Update());
            Console.WriteLine(_controller.Delete());
            Console.WriteLine(_controller.GetOne());
        }
    }
}
