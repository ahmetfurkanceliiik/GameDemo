using System;
using GameDemo.Abstract;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GamerManager : IGamerService
    {

        public GamerManager()
        {

        }
        private IVerificationService _verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }
        public void Add(Gamer gamer)
        {
            if (_verificationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" adlı oyuncu eklendi");
            }
            else
            {
                throw new Exception("Bilgilerinizi kontrol ediniz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncunun bilgileri silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncunun bilgileri güncellendi");
        }
    }
}
