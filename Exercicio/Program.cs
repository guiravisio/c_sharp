// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe a opção desejada:");
Console.WriteLine("1 - Inserir novo aluno");
Console.WriteLine("2 - Listar alunos");
Console.WriteLine("3 - Calcular média");
Console.WriteLine("X - Sair");

string opcaoUsuario = Console.Readline();

while (opcaoUsuario.ToUpper() != 'X'){
    switch(opcaoUsuario){
        case "1": //adicionar aluno

        break;

        case "2": //listar alunos

        break;

        case "3": //calcular média

        break;

        default:
            throw new ArgumentOutOfRangeException();
    }
    Console.WriteLine("Informe a opção desejada:");
    Console.WriteLine("1 - Inserir novo aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Calcular média");
    Console.WriteLine("X - Sair");

    opcaoUsuario = Console.Readline();
}