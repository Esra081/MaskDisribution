using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //constructor, runs when called new
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person) 
        {
            PttManager pttManager = new PttManager(new ForeignManager());
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");

            }
        }
    }
}
