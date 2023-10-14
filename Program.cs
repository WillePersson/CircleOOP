namespace CircleOOP
{//Wille persson - .NET23
    internal class Program
    { 
        static void Main(string[] args)
        {
            //två olika circklar skapade med hjälp av klassen
            Circle circle1 = new Circle(3.141f,5);
            Circle circle2 = new Circle(3.141f,6);
           
            //snabb text sedan kalla på methoden getArea
            Console.WriteLine("Arean på en circel med radien 5 är");
            circle1.getArea();
           
            Console.WriteLine("Arean på en circel med radien 6 är");
            circle2.getArea();
        } 
    }
    class Circle
    {       //Fields what an object has
        float _pi;
        int _Radius;

        public Circle(float pi ,int Radius)//Full specification constructor 
        {
            _pi = pi;
            _Radius = Radius;
        } 
        
        public void getArea()//Method
        {
            float Area = _Radius * _Radius * _pi;
            Console.WriteLine(Area);
        }
    }
}