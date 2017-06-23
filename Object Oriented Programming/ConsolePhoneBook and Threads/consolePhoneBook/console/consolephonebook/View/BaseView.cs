using ConsolePhonebook.Entity;
using ConsolePhonebook.Repository;
using ConsolePhonebook.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhonebook.View
{
    //T1 repository, T2 entity
    public class BaseView<T1,T2> where T1:BaseRepository<T2>
                                 where T2:BaseEntity,new()
    {

        public void Show(BaseManagementEnum choice, T1 repository)
        {
            try
            {
                switch (choice)
                {
                    case BaseManagementEnum.Select:
                        {
                            //GetAll();
                            break;
                        }
                    case BaseManagementEnum.View:
                        {
                            //View();
                            break;
                        }
                    case BaseManagementEnum.Insert:
                        {
                            //Add();
                            break;
                        }
                    case BaseManagementEnum.Update:
                        {
                            //Update();
                            break;
                        }
                    case BaseManagementEnum.Delete:
                        {
                            Delete(repository);
                            break;
                        }
                    case BaseManagementEnum.Exit:
                        {
                            return;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadKey(true);
            }
        }

        protected void GetAll(int id)
        {
            PhonesRepository phonesRepository = new PhonesRepository("phones.txt");
            List<Phone> phones = phonesRepository.GetAll(id);
            foreach (Phone phone in phones)
            {
                Console.WriteLine("ID:" + phone.Id);
                Console.WriteLine("Phone :" + phone.PhoneNumber);
                Console.WriteLine("########################################");
            }

            Console.ReadKey(true);
        }

        private void Delete(T1 repository)
        {
            Console.Clear();
            Console.WriteLine("Delete: ");
            Console.Write("Id: ");
            int contactId = Convert.ToInt32(Console.ReadLine());
            T2 entity = repository.GetById(contactId);
            if (entity == null)
            {
                Console.WriteLine("Not found!");
            }
            else
            {
                repository.Delete(entity);
                Console.WriteLine("Deleted successfully.");
            }
            Console.ReadKey(true);
        }

        protected void Add(T1 repository,T2 entity)
        {

            repository.Save(entity);
            Console.WriteLine("Saved successfully!");
        }
    }
}
