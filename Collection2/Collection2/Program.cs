namespace Collection2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkdedList = new LinkedList();
            linkdedList.Add(56);
            linkdedList.Add(30);
            linkdedList.Add(70);
            linkdedList.Display();
            //linkdedList.InsertAtParticularPosition(2,30);
            //linkdedList.RemoveFirstNode();
            linkdedList.RemoveLastNode();
            linkdedList.Display();
        }
    }
}