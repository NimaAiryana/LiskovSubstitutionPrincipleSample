namespace LiskovSubstitutionPrincipleSample
{
    internal class Manager : Employee
    {
        public override void Print() => Console.WriteLine("Manager");
    }
}
