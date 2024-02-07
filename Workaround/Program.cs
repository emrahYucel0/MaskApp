using Business.Concrete;
using Entities.Concretes;

Person person = new();

person.FirstName = "Emrah";
person.LastName = "Yücel";
person.DateOfBirthYear = 1985;
person.NationalIdentity = 11223344556;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);