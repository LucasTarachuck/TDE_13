public class Empresa{
    private List<Funcionario> Funcionarios;
    public Empresa(){
        Funcionarios = new List<Funcionario>();
    }
    public void AdicionarFuncionarios(Funcionario funcionario){
        Funcionarios.Add(funcionario);
    }
    public void ListarFuncionario(){
        foreach(var funcionario in Funcionarios){
            Console.WriteLine($"Nome do funcionário: {funcionario.Nome}");
            Console.WriteLine($"O salário do funcionário: {funcionario.CalcularSalario()}");
        }
        
    }
}