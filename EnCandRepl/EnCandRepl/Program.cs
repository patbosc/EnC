using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace EnCandRepl
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the directory that contains family tree json files
            string filelocation = "";
            do
            {
                WriteLine("Please enter the full file location you want to save reports in: ");
                filelocation = ReadLine();
            } while (!Directory.Exists(filelocation));

            List<AncestryTree> files = new List<AncestryTree>();

            try
            {
                var dir = Path.GetDirectoryName(filelocation);
                //get json files in directory
                string[] jsonfiles = Directory.GetFiles(dir, "*.json");

                foreach (var file in jsonfiles)
                {
                    //read json into tree
                    //add tree to array
                }
                //find and print common ancestors between pairs of trees
                var commonAncestors = AncestorsFromList(files);
                printAncestors(commonAncestors);
                ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void printAncestors(object commonAncestors)
        {
            throw new NotImplementedException();
        }

        private static object AncestorsFromList(List<AncestryTree> files)
        {
            throw new NotImplementedException();
        }
    }
}
