﻿using System;
using System.Collections.Generic;
using System.IO;
using ConsolePhonebook.Entity;

namespace ConsolePhonebook.Repository
{
    public class BaseRepository<T> where T : Entity.BaseEntity, new()
    {
        protected readonly string filePath;

        public BaseRepository(string filePath)
        {
            this.filePath = filePath;
        }

        private int GetNextId()
        {
            FileStream fs = new FileStream(this.filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            int id = 1;
            try
            {
                while (!sr.EndOfStream)
                {
                    T item = new T();

                    PopulateEntity(sr, item);

                    if (id <= item.Id)
                    {
                        id = item.Id + 1;
                    }
                }
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            return id;
        }

        protected virtual void PopulateEntity(StreamReader sr, T item)
        { }

        protected virtual void WriteEntity(StreamWriter sw, T item)
        { }

        private void Insert(T item)
        {
            item.Id = GetNextId();

            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                WriteEntity(sw, item);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        private void Update(T item)
        {
            string tempFilePath = "temp." + filePath;

            FileStream ifs = new FileStream(filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(ifs);

            FileStream ofs = new FileStream(tempFilePath, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(ofs);

            try
            {
                while (!sr.EndOfStream)
                {
                    T itemSrc = new T();
                    PopulateEntity(sr, itemSrc);

                    if (itemSrc.Id != item.Id)
                    {
                        WriteEntity(sw, itemSrc);
                    }
                    else
                    {
                        WriteEntity(sw, item);
                    }
                }
            }
            finally
            {
                sw.Close();
                ofs.Close();
                sr.Close();
                ifs.Close();
            }

            File.Delete(filePath);
            File.Move(tempFilePath, filePath);
        }

        public T GetById(int id)
        {
            FileStream fs = new FileStream(this.filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    T item = new T();
                    PopulateEntity(sr, item);

                    if (item.Id == id)
                    {
                        return item;
                    }
                }
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            return null;
        }

        public List<T> GetAll()
        {
            List<T> result = new List<T>();

            FileStream fs = new FileStream(this.filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    T item = new T();
                    PopulateEntity(sr, item);
                    result.Add(item);
                }
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            return result;
        }

        public void Delete(T item)
        {
            string tempFilePath = "temp." + filePath;

            FileStream ifs = new FileStream(filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(ifs);

            FileStream ofs = new FileStream(tempFilePath, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(ofs);

            try
            {
                while (!sr.EndOfStream)
                {
                    T itemSrc = new T();
                    PopulateEntity(sr, itemSrc);

                    if (itemSrc.Id != item.Id)
                    {
                        WriteEntity(sw, itemSrc);
                    }
                }
            }
            finally
            {
                sw.Close();
                ofs.Close();
                sr.Close();
                ifs.Close();
            }

            File.Delete(filePath);
            File.Move(tempFilePath, filePath);
        }

        public void Save(T item)
        {
            if (item.Id > 0)
            {
                Update(item);
            }
            else
            {
                Insert(item);
            }
        }
    }
}
