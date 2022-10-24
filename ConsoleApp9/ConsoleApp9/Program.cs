using ConsoleApp9;

class Program {
    static void Main(string[] args) {
        Autopujcovna A = new Autopujcovna("AAAuto");
        Autopujcovna B = new Autopujcovna("BBBeuto");

        A.VypisAuticka();
        Console.WriteLine();
        B.VypisAuticka();

    }
}