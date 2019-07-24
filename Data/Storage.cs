using System;
using System.Collections.Generic;
using OOFS.Model;

namespace OOFS.Storage 
{
    // This is definitely not the best implementation for a singleton object, 
    // but it's ok for this example since we're not dealing with concurrent usage
    public sealed class FSStorage
    {
        private static FSStorage instance = null;
        private static List<Drive> drives = new List<Drive>();
        private static object padlock = new object();

       private FSStorage() {}
       public static FSStorage Instance
       {
           get
           {
               lock(padlock)
               {
                   if(instance == null)
                   {
                       instance = new FSStorage();
                   }
               }
            return instance;
           }
       }

       public List<Drive> Drives 
       {
           get
           {
               return drives;
           }
       }
    }
}