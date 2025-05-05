using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informe o Endereço: ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("O Cliente é Pessoa Física (f) ou Pessoa Jurídica (j) ?");
            string var_tipo = Console.ReadLine();
           

            string tipoCliente = var_tipo == "f" ? "Pessoa Física" : "Pessoa Jurídica";
            string documento1, documento2;
            float val_pag, total;

            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Digite o CPF");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Digite o RG");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                total = pf.total;
                documento1 = pf.cpf;
                documento2 = pf.rg;
            }
            else if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Digite o CNPJ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Digite a Inscrição Estadual");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                total = pj.total;
                documento1 = pj.cnpj;
                documento2 = pj.ie;
            }
            else
            {
                Console.WriteLine("Tipo de cliente inválido!");
                return;
            }

            // Exibe os dados em formato de tabela
            Console.WriteLine("\nTabela de Dados do Cliente:");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"| {"Nome",-15} | {"Endereço",-20} | {"Tipo",-15} |");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"| {var_nome,-15} | {var_endereco,-20} | {tipoCliente,-15} |");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"| Documento 1: {documento1,-15} | Documento 2: {documento2,-15} |");
            Console.WriteLine($"| Valor da Compra: R$ {val_pag,-10} | Total com Imposto: R$ {total,-10} |");
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
