using ConsolePhonebook.Entity;
using ConsolePhonebook.Repository;
using ConsolePhonebook.Service;
using ConsolePhonebook.Tools;
using System;
using System.Collections.Generic;

namespace ConsolePhonebook.View
{
    public class ContactsManagerView:BaseView<ContactsRepository,Contact>
    {
        public void Show()
        {
            while (true)
            {
                BaseManagementEnum choice = RenderMenu();
                ContactsRepository contactsRepo = new ContactsRepository("contacts.txt");
                Show(choice,contactsRepo);
            }
        }

        private BaseManagementEnum RenderMenu()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Contacts management:");
                Console.WriteLine("[G]et all");
                Console.WriteLine("[V]iew");
                Console.WriteLine("[A]dd");
                Console.WriteLine("[E]dit");
                Console.WriteLine("[D]elete");
                Console.WriteLine("E[x]it");

                string choice = Console.ReadLine();
                switch(choice.ToUpper())
                {
                    case "G":
                    {
                        return BaseManagementEnum.Select;
                    }
                    case "V":
                    {
                        return BaseManagementEnum.View;
                    }
                    case "A":
                    {
                        return BaseManagementEnum.Insert;
                    }
                    case "E":
                    {
                        return BaseManagementEnum.Update;
                    }
                    case "D":
                    {
                        return BaseManagementEnum.Delete;
                    }
                    case "X":
                    {
                        return BaseManagementEnum.Exit;
                    }
                    default :
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
            Console.Clear();
            //PhonesRepository phonesRepository = new PhonesRepository("phones.txt");
            ContactsRepository contactsRepository = new ContactsRepository("contacts.txt");
            List<Contact> contacts = contactsRepository.GetAll(AuthenticationService.LoggedUser.Id);
            foreach (Contact contact in contacts)
            {
                Console.WriteLine("ID:" + contact.Id);
                Console.WriteLine("Name :" + contact.FullName);
                Console.WriteLine("Email :" + contact.Email);
                base.GetAll(contact.Id);
                //List<Phone> phones = phonesRepository.GetAll(contact.Id);
                //foreach (Phone phone in phones)
                //{
                //    Console.WriteLine("ID:" + phone.Id);
                //    Console.WriteLine("Phone :" + phone.PhoneNumber);
                //}
                //Console.WriteLine("########################################");
            }

            Console.ReadKey(true);
        }

        private void Add()
        {
            
            Console.Clear();

            Contact contact = new Contact();
            contact.ParentUserId = AuthenticationService.LoggedUser.Id;
            
            Console.WriteLine("Add new Contact:");
            Console.Write("Full Name: ");
            contact.FullName = Console.ReadLine();
            Console.Write("Email: ");
            contact.Email = Console.ReadLine();
            ContactsRepository contactsRepository = new ContactsRepository("contacts.txt");
            base.Add(contactsRepository, contact);
            
            //contactsRepository.Save(contact);

            //Console.WriteLine("Contact saved successfully.");
            Console.ReadKey(true);

            PhonesManagerView phoneManagerView = new PhonesManagerView(contact);
            phoneManagerView.Show();
        }

        //private void Delete()
        //{
        //    ContactsRepository contactsRepository = new ContactsRepository("contacts.txt");

        //    Console.Clear();

        //    Console.WriteLine("Delete: ");
        //    Console.Write("Id: ");
        //    int contactId = Convert.ToInt32(Console.ReadLine());

        //    Contact contact = contactsRepository.GetById(contactId);
        //    if (contact == null)
        //    {
        //        Console.WriteLine("Not found!");
        //    }
        //    else
        //    {
        //        contactsRepository.Delete(contact);
        //        Console.WriteLine("Deleted successfully.");
        //    }
        //    Console.ReadKey(true);
        //}

        private void View()
        {
            Console.Clear();

            Console.Write("Contact ID: ");
            int contactId = Convert.ToInt32(Console.ReadLine());

            ContactsRepository contactsRepository = new ContactsRepository("contacts.txt");
            PhonesRepository phonesRepository = new PhonesRepository("phones.txt");

            Contact contact = contactsRepository.GetById(contactId);
            if (contact == null)
            {
                Console.Clear();
                Console.WriteLine("Contact not found.");
                Console.ReadKey(true);
                return;
            }

            PhonesManagerView phonesManagerView = new PhonesManagerView(contact);
            phonesManagerView.Show();
        }

        private void Update()
        {
            Console.Clear();

            Console.Write("Contact ID: ");
            int contactId = Convert.ToInt32(Console.ReadLine());

            ContactsRepository contactsRepository = new ContactsRepository("contacts.txt");
            Contact contact = contactsRepository.GetById(contactId);

            if (contact == null)
            {
                Console.Clear();
                Console.WriteLine("Contact not found.");
                Console.ReadKey(true);
                return;
            }

            Console.WriteLine("Editing Contact (" + contact.FullName + ")");
            Console.WriteLine("ID:" + contact.Id);

            Console.WriteLine("Name :" + contact.FullName);
            Console.Write("New Name:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Email :" + contact.Email);
            Console.Write("New Email :");
            string email = Console.ReadLine();

            if (!string.IsNullOrEmpty(fullName))
                contact.FullName = fullName;
            if (!string.IsNullOrEmpty(email))
                contact.Email = email;

            contactsRepository.Save(contact);

            Console.WriteLine("Contact saved successfully.");
            Console.ReadKey(true);

            PhonesManagerView phoneManagerView = new PhonesManagerView(contact);
            phoneManagerView.Show();
        }
    }
}
