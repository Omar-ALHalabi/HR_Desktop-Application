using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBuisnessLayerHrHammoud;
using System.IO;
using System.Windows.Forms;

namespace HrHammoudCompany
{
    internal class clsGlobal
    {
         public static ClsUsers CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            try
            {
                string GetDirectory = Directory.GetCurrentDirectory();

                string FilePath = GetDirectory + "\\Data.txt";

                if (Username == "" && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;

                }
                string dataToSave = Username + "#//#" + Password;

                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }








        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string currentDirectory = Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath = currentDirectory + "\\Data.txt";

                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

       static public bool CheckPermission(byte Totalpermission, byte unitPer)
        {
            ;
            byte result = Convert.ToByte(Totalpermission & unitPer);
            if (result == unitPer)
            {

                return true;
            }


            return false;
        }

    }
}
