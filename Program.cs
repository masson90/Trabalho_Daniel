using System;
using System.Collections.Generic;

namespace Trabalho_Adicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Elabore uma aplicação que permita ao usuário:                           A consulta poderá ser feita por: 
                    Incluir                                                            RA: 
                    Excluir                                                            Nome do Aluno
                    Consultar                                                          A exclusão dos dados deve ocorrer pelo Nome do aluno.
               Em um List<T> para ALUNOS
               Monte um menu para o usuário.
             */

            // Nome, RA, CPF, Curso, Nascimento,

            List<Aluno> cadastro = new List<Aluno>();
            int escolha = 1, cont = 0;
            string del, consulta;
            
            

            while (escolha > 0 && escolha <= 3)
            {                               //MENU
                var cad = new Aluno();
                Console.WriteLine("########################################################");
                Console.WriteLine(" Escolha uma das opções a baixo: ");                
                Console.WriteLine(" 1 - CADASTRAR");
                Console.WriteLine(" 2 - EXCLUIR");
                Console.WriteLine(" 3 - CONSULTAR");
                Console.WriteLine(" 0 - SAIR");
                Console.WriteLine("########################################################");
                escolha = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                
                if(escolha == 1)
                {   // 1 - CADASTRO
                    // Nome, CPF, RA, Curso, Nascimento;
                    Console.WriteLine("CADASTRO:\n\n");
                    Console.WriteLine("Digite o Nome:");
                    cad.Nome = Console.ReadLine().ToUpper();
                    Console.WriteLine("Digite o CPF:");
                    cad.CPF = Console.ReadLine();
                    Console.WriteLine("Digite o RA:");
                    cad.RA = Console.ReadLine();
                    Console.WriteLine("Digite o Curso:");
                    cad.Curso = Console.ReadLine();
                    Console.WriteLine("Digite a Data de Nascimento: XX/XX/XXXX");
                    cad.Nascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Cadastro finalizado!");
                    cadastro.Add(cad);

                    Console.Clear();
                }

                else if (escolha == 2)
                {   // 2 - EXCLUIR -- Apenas pelo nome
                    var excluir = new Aluno();

                    foreach (var item in cadastro)
                    {
                        Console.WriteLine(item.Nome);
                    }
                    Console.WriteLine("----");

                    Console.WriteLine("Estes sao os nomes cadastrados\n\n");
                    Console.WriteLine("Qual nome gostaria de deletar:");
                    del = (Console.ReadLine().ToUpper());
                    foreach (var item in cadastro)
                    {                        
                        
                        if (del == item.Nome)
                        {   // Nome, CPF, RA, Curso, Nascimento;
                            Console.WriteLine("Entrou no IF");
                            excluir = item;
                        }                      

                    }
                    cadastro.Remove(excluir);                    
                    Console.Clear();                   

                    
                    
                }

                else if (escolha == 3)
                {   // 3 - CONSULTAR -  RA e nome
                    if (cadastro.Count == 0)
                    {
                        Console.WriteLine("Não existem cadastros!");
                    }                    
                    else
                    {
                        Console.WriteLine("Informe o NOME ou RA do aluno para Consultar:");
                        consulta = Console.ReadLine().ToUpper();
                        Console.WriteLine(" ");

                        foreach (var item in cadastro)
                        {   // Nome, CPF, RA, Curso, Nascimento;
                            if(consulta == item.Nome || consulta == item.RA)
                            {
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("CPF: " + item.CPF);
                                Console.WriteLine("RA: " + item.RA);
                                Console.WriteLine("Curso: " + item.Curso);
                                Console.WriteLine("Data de Nascimento: " + item.Nascimento);

                                Console.WriteLine("-----------------------");
                                cont++;
                            }
                            
                        }
                        if(cont == 0)
                        {
                            Console.WriteLine("Nome não encontrado na base da dados!");
                        }
                        cont = 0;
                        
                    }       

                }

            }

        }
    }
}
