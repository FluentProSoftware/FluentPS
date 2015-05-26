namespace FluentPro.FluentPS.CodeGenerator.Operations
{
    public interface IOperation
    {
        void Help();

        void Run(string[] args);
    }
}
