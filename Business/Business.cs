using System;
using System.Collections.Generic;
using OOFS.Model;
using OOFS.Storage;

namespace OOFS.Business
{
    public class Business
    {
        public static List<Drive> Dir()
        {
            return FSStorage.Instance.Drives;
        }

        public static string Create(string type, string name, string path)
        {
            if(type.ToLower() == "drive")
            {
                FSStorage.Instance.Drives.Add(new Drive(name, path));
            }
            return path + "\\" + name;
        }

        public string Delete(string path)
        {
            return path + " deleted successfully";
        }

        public string Move(string sourcePath, string destinationPath)
        {
            return sourcePath + " successfully moved to " + destinationPath;
        }

        public string WriteToFile(string path, string content)
        {
            return path + " updated successfully";
        }
    }
}