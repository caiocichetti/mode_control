﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mode_control
{
    public class ListSports : List<Sports>
    {
        // Path name defined for the development environment
        string fileName = "C:\\esportes.txt";

        // Constructor
        public ListSports()
            : base()
        {
            load();
        }

        // Destructor
        ~ListSports()
        {
            save();
        }

        //Insert
        public void Add(Sports obj)
        {
            if (!alreadyExist(obj))
            {
                base.Add(obj);
            }
        }

        // Consult data
        public Sports Query(string mode)
        {
            Sports item = null;

            foreach (Sports data in this)
            {
                if (data.Mode == mode)
                {
                    item = data;
                }
            }
            return item;
        }

        public List<Sports> Queryl(bool mix)
        {
            List<Sports> item = new List<Sports>();
            foreach (Sports data in this)
            {
                if (data.Mixed)
                {
                    item.Add(data);
                }
            }

            return item;
        }

        // Delete data
        public void Delete(Sports obj)
        {
            Sports item = Query(obj.Mode);

            if (item != null)
            {
                base.Remove(item);
            }
        }

        // Update data
        public void Update(Sports obj)
        {
            Sports item = Query(obj.Mode);

            if (item != null)
            {
                item.toJson = obj.JsonSerialize();
            }
        }

        // Checks if there is
        private bool alreadyExist(Sports obj)
        {
            bool item = false;

            foreach (Sports data in this)
            {
                if (data.Equals(obj))
                {
                    item = true;
                }
            }
            return item;
        }

        // Load from Disk
        private void load()
        {
            this.Clear();
            try
            {
                StreamReader input = new StreamReader(fileName);

                string row;

                try
                {
                    while ((row = input.ReadLine()) != null)
                    {
                        Sports newSport = new Sports("", 0, 0, false);
                        newSport.toJson = row;
                        if (newSport.Mode.Length > 0)
                        {
                            this.Add(newSport);
                        }
                    }
                }
                catch { }

                input.Close();
            }
            catch { }
        }

        //  Burn to disc
        private void save()
        {
            try
            {
                StreamWriter output = new StreamWriter(fileName, false);
                foreach (Sports row in this)
                {
                    try
                    {
                        output.WriteLine(row.JsonSerialize());
                    }
                    catch { }
                }
                output.Close();
            }
            catch { }
        }
    }
}
