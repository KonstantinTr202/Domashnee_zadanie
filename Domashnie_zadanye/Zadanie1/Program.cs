namespace Zadanie1
{
    public interface ISelectable
    {
        void OnSelect();
    }
    public interface IUpdatable
    {
        void Refresh();
    }
    class Screen : ISelectable, IUpdatable
    {

        public void OnSelect()
        {
            Console.WriteLine("ISelectable");
        }

        public void Refresh()
        {
            Console.WriteLine("IUpdatable");
        }
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.OnSelect();
            screen.Refresh();
        }
    }
}
