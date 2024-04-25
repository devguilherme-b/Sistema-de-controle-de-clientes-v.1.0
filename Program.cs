using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
                Console.WriteLine("Informe seu nome:");
                string var_nome = Console.ReadLine();
                Console.WriteLine("Informe seu endereço:");
                string var_endereco = Console.ReadLine();
                Console.WriteLine("Você é Pessoa Física(f) ou Pessoa Jurídica(j) ?");
                Console.WriteLine("Para \"Pessoa Física\" digite (f), para \"Pessoa Jurídica\" digite (j) ");
                string var_tipo = Console.ReadLine();
                if (var_tipo == "f")
                {
                    // Pessoa Física 
                    Pessoa_Fisica pf = new Pessoa_Fisica();
                    pf.nome = var_nome;
                    pf.endereco = var_endereco;
                    Console.WriteLine("Informe seu CPF:");
                    pf.cpf = Console.ReadLine();
                    Console.WriteLine("Informe seu RG:");
                    pf.rg = Console.ReadLine();
                    Console.WriteLine("Informe o valor da compra:");
                    val_pag = float.Parse(Console.ReadLine()); // O método "float.Parse" converte uma string em variável númerica do tipo float
                    pf.Pagar_Imposto(val_pag);
                    Console.WriteLine("------- Pessoa Física -------");
                    Console.WriteLine("Nome ...........: " + pf.nome);
                    Console.WriteLine("Endereço .......: " + pf.endereco);
                    Console.WriteLine("CPF ............: " + pf.cpf);
                    Console.WriteLine("RG .............: " + pf.rg);
                    Console.WriteLine("Valor da compra : " + pf.valor.ToString("C"));
                    Console.WriteLine("Imposto ........: " + pf.valor_imposto.ToString("C"));
                    Console.WriteLine("Toal a pagar ...: " + pf.total.ToString("C")); // O método "ToString" converte o valor da var em caractere
                    Console.WriteLine("O imposto para Pessoa Física é de 10% sobre o valor.");
                } if (var_tipo == "j")
                {
                    // Pessoa Jurídica 
                    Pessoa_Juridica pj = new Pessoa_Juridica();
                    pj.nome = var_nome;
                    pj.endereco = var_endereco;
                    Console.WriteLine("Informe seu CNPJ:");
                    pj.cnpj = Console.ReadLine();
                    Console.WriteLine("Informe seu IE(Inscrição Estadual):");
                    pj.ie = Console.ReadLine();
                    Console.WriteLine("Informe o valor da compra:");
                    val_pag = float.Parse(Console.ReadLine()); // O método "float.Parse" converte uma string em variável númerica do tipo float
                    pj.Pagar_Imposto(val_pag);
                    Console.WriteLine("-------- Pessoa Jurídica -------");
                    Console.WriteLine("Nome ...........: " + pj.nome);
                    Console.WriteLine("Endereço .......: " + pj.endereco);
                    Console.WriteLine("CNPJ ...........: " + pj.cnpj);
                    Console.WriteLine("IE .............: " + pj.ie);
                    Console.WriteLine("Valor da compra : " + pj.valor.ToString("C"));
                    Console.WriteLine("Imposto ........: " + pj.valor_imposto.ToString("C"));
                    Console.WriteLine("Toal a pagar ...: " + pj.total.ToString("C")); // O método "ToString" converte o valor da var em caractere
                    Console.WriteLine("O imposto para Pessoa Jurídica é de 20% sobre o valor");
                }
        }
    }
}