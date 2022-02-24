using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public interface IAnimal { void Comer(); }

    public class Cachorros : IAnimal
    {
        public void Comer()
        {
            //
        }
    }

    public class Gatos : IAnimal
    {
        public void Comer()
        {
            //
        }
    }

    public class PetShop
    {
        private IAnimal Pet;

        public IAnimal PetAtual;

        public PetShop()
        {
            //
        }

        public PetShop(IAnimal Animal)
        {
            this.Pet = Animal;
        }

        public void DarDeComer()
        {
            Pet.Comer();
        }

        public void DarBanho()
        {
            // Usar PetAtual
        }

        public void AplicarVacina(IAnimal AnimalNaFila)
        {
            // User AnimalNaFila
        }

    }

    public class Dono
    {
        Cachorros MeuDog = new Cachorros();
        
        public void CuidarDoMeuBichinho()
        {
            PetShop Alimentar = new PetShop(MeuDog);
            Alimentar.DarDeComer();

            PetShop Banhar = new PetShop();
            Banhar.PetAtual = MeuDog;
            Banhar.DarBanho();

            PetShop Vacinar = new PetShop();
            Vacinar.AplicarVacina(MeuDog);
        }

    }
}







