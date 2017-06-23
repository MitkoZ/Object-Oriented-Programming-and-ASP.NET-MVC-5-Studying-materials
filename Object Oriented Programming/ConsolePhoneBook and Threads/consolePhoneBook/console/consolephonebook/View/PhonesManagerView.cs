using ConsolePhonebook.Entity;
using ConsolePhonebook.Repository;
using ConsolePhonebook.Service;
using ConsolePhonebook.Tools;
using System;
using System.Collections.Generic;

namespace ConsolePhonebook.View
{
    public class PhonesManagerView:BaseView<PhonesRepository,Phone>
    {
        public void Show()
        {
            while (true)
            {
                BaseManagementEnum choice = RenderMenu();
                PhonesRepository phoneRepo = new PhonesRepository("phones.txt");
                Show(choice,phoneRepo);
            }
        }

        private BaseManagementEnum RenderMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Phones management (" + this.contact.FullName + ")");
                Console.WriteLine("ID:" + contact.Id);
                Console.WriteLine("Name :" + contact.FullName);
                Console.WriteLine("Email :" + contact.Email);
                Console.WriteLine("##########################");
                Console.WriteLine("[G]et all");
                Console.WriteLine("[A]dd");
                Console.WriteLine("[D]elete");
                Console.WriteLine("E[x]it");

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "G":
                        {
                            return BaseManagementEnum.Select;
                        }
                    case "A":
                        {
                            return BaseManagementEnum.Insert;
                        }
                    case "D":
                        {
                            return BaseManagementEnum.Delete;
                        }
                    case "X":
                        {
                            return BaseManagementEnum.Exit;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice.");
                            Console.ReadKey(true);
                            break;
                        }
                }
            }
        }

        private void GetAll()
        {
            //    Console.Clear();
            //    PhonesRepository phonesRepository = new PhonesRepository("phones.txt");
            //    List<Phone> phones = phonesRepository.GetAll(this.contact.Id);
            //    foreach (Phone phone in phones)
            //    {
            //        Console.WriteLine("ID:" + phone.Id);
            //        Console.WriteLine("Phone :" + phone.PhoneNumber);
            //        Console.WriteLine("########################################");
            //    }
            base.GetAll(this.contact.Id);
            Console.ReadKey(true);
        }

        private void Add()
        {
            Console.Clear();

            Phone phone = new Phone();
            phone.ParentContactId = this.contact.Id;

            Console.WriteLine("Add new Phone:");
            Console.Write("Phone: ");
            phone.PhoneNumber = Console.ReadLine();

            PhonesRepository phonesRepository = new PhonesRepository("phones.txt");
            //phonesRepository.Save(phone);

            //Console.WriteLine("Phone saved successfully.");
            base.Add(phonesRepository, phone);
            Console.ReadKey(true);
        }

        //private void Delete()
        //{
        //    PhonesRepository phonesRepository = new PhonesRepository("phones.txt");

        //    Console.Clear();

        //    Console.WriteLine("Delete: ");
        //    Console.Write("Id: ");
        //    int phoneId = Convert.ToInt32(Console.ReadLine());

        //    Phone phone = phonesRepository.GetById(phoneId);
        //    if (phone == null)
        //    {
        //        Console.WriteLine("Not found!");
        //    }
        //    else
        //    {
        //        phonesRepository.Delete(phone);
        //        Console.WriteLine("Deleted successfully.");
        //    }
        //    Console.ReadKey(true);
        //}

        public PhonesManagerView(Contact contact)
        {
            this.contact = contact;
        }

        private Contact contact = null;
    }
}
