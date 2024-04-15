using System;
using System.Diagnostics.Contracts;
namespace backend02 {
    class Program
    {
        static void Main(string[] args)
        {
            
            float val_pag;
            Console.WriteLine("Nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Endereço: ");
            string var_endereco = Console.ReadLine();
            string var_tipo = "";

            while(var_tipo != "f" && var_tipo != "j"){
            Console.WriteLine("Pessoa fisica(f) ou Juridica (j)");
            var_tipo = Console.ReadLine();

            // Pessoa Física
            if(var_tipo == "f") {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.name = var_nome;
                pf.adress = var_endereco;
                Console.WriteLine("CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Valor da Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.PayTax(val_pag);
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome..............: " + pf.name);
                Console.WriteLine("endereço..........: " + pf.adress);
                Console.WriteLine("cpf...............: " + pf.cpf);
                Console.WriteLine("rg................: " + pf.rg);
                Console.WriteLine("Valor da compra...: " + pf.value);
                Console.WriteLine("Imposto...........: " + pf.tax_value);
                Console.WriteLine("Total a pagar.....: " + pf.total);
            }

            // Pessoa Juridica
            if(var_tipo == "j") {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.name = var_nome;
                pj.adress = var_endereco;
                Console.WriteLine("CPNJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Valor da Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.PayTax(val_pag);
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome...............: " + pj.name);
                Console.WriteLine("endereço...........: " + pj.adress);
                Console.WriteLine("cnpj.................: " + pj.cnpj);
                Console.WriteLine("ie.................: " + pj.ie);
                Console.WriteLine("Valor da compra....: " + pj.value);
                Console.WriteLine("Imposto............: " + pj.tax_value);
                Console.WriteLine("Total a pagar......: " + pj.total);
            }
             if(var_tipo != "f" && var_tipo != "j") {
                Console.WriteLine("Opção inválida, digite (f) ou (j)");
             }
            }
        }
    }
}