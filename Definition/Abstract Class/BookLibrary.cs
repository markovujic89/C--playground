namespace Definition.Abstract_Class
{
    public class BookLibrary : Library
    {
        private int _maxStorageSize;

        private string _name;
        
        public BookLibrary(int maxStorageSize, string name):base(maxStorageSize, name)
        {
            _maxStorageSize = maxStorageSize;
            _name = name;
        }

        public override int MaxStorageSize { get { return _maxStorageSize; } }

        public override string Name { get { return _name; } }


        public override void PrintTitle(string name)
        {
            Console.WriteLine(name);
        }
    }
}
