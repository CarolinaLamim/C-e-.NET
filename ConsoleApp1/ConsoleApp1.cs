using (System.Collection.Generic);
using (System.Text);   
using (Enum);
using (Interface);
using (Primeiro);
{
     resource
}
{
     
}
{
     Name
} 

namespace Primeiro
{    
    class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
    }
}

namespace Interface
{
    interface IAnimal
    {
        void Nome(string Nome);
        void Dono(string NomeDono);
        void Especie(string Especie);
    }

    class Animal : IAnimal 
    {
       public string Nome { get; set; }
       public string NomeDono { get; set; }
       public string Especie { get; set; }

       void IAnimal.Nome(string Nome) {
           this.Nome = Nome; 
       }

       void IAnimal.Dono(string NomeDono) {
           this.NomeDono = NomeDono; 
       }

       void IAnimal.Especie(string Especie) {
           this.Especie = Especie; 
       }
    }
    
}

namespace Enum
{
    enum Pessoas
    {
        Giovanna,
        Julia,
        Gustavo,
        João, 
        Mariana
    }
}

namespace Csharp
{
    class Program
    {
        Pessoas Pessoa1 = Pessoas.João;
        var pessoa2 = (Pessoas)0;

        Animal animal  = new Animal();

        animal.Nome = "Rex";
        animal.NomeDono = "Pedro";
        animal.Especie = "Cachorro";
    }
}

docs.microsoft.com/pt-br/dotnet 