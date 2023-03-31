//Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. A     senha     válida     é     o     número     1234. Devem     ser    impressas     as    seguintes     mensagens:ACESSO    PERMITIDO    caso    a    senha    seja    válida.ACESSO    NEGADO    caso    a    senha    seja    inválida.

// Algoritimo 
// Entrada: senha
// Proscessamento: 

//Entrada 

Console.WriteLine(@$"
--------------------------------
|        Programa para         |
|      validar uma senha       |
|                              |
--------------------------------
");

Console.WriteLine($"Digite seu senha:");
int senha = int.Parse(Console.ReadLine());

// Processamento 


// Saida
if (senha==1234)
{
Console.WriteLine("ACESSO PERMITIDO");   
}
else
{
Console.WriteLine("ACESSO NEGADO");
}
