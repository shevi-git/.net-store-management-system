namespace Tools
{
    public static class LogManager
    {
        private readonly static string RoutLog = "Log";
        private static string prefix = "\t";

        public static string RouterCurrentFolder()
        {
            return RoutLog + "/" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString();
        }

        public static string RouterCurrentFile()
        {
            return RouterCurrentFolder() + "/" + DateTime.Now.Day.ToString() + ".txt";
        }

        public static void WriteToLog(string nameProject, string nameFunc, string message)

        {
            string folder = RouterCurrentFolder();
            string file = RouterCurrentFile();
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }
            using (StreamWriter writerText = new StreamWriter(file,true))
            {
                writerText.WriteLine($"{DateTime.Now}\t{nameProject}.{nameFunc}:\t{message}");
            }
        }


        public static void DelteFolder()
        {
            string folderMonth;
            string folderYear;
            string[] subDirectories = Directory.GetDirectories(RoutLog);
            for (int i = 0; i < subDirectories.Length; i++)
            {
                folderMonth = subDirectories[i].Substring(2);
                folderYear = subDirectories[i].Substring(3, 4);
                if (DateTime.Now.Month - 2 > 0)
                {
                    if (!DateTime.Now.Year.Equals(folderYear))
                    {
                        Directory.Delete(subDirectories[i]);
                    }
                    else
                    {
                        if (!(DateTime.Now.Month).Equals(folderMonth) || !(DateTime.Now.Month - 1).Equals(folderMonth) ||
                            !(DateTime.Now.Month - 2).Equals(folderMonth))
                            Directory.Delete(subDirectories[i]);
                    }
                }
                else
                {
                    if (!folderYear.Equals(DateTime.Now.Year - 1))
                    {
                        Directory.Delete(subDirectories[i]);
                    }
                    if (DateTime.Now.Month.Equals(2))
                    {
                        if (!subDirectories[i].Equals(12) && !subDirectories[i].Equals(1))
                        {
                            Directory.Delete(subDirectories[i]);
                        }
                    }
                    if (DateTime.Now.Month.Equals(1))
                    {
                        if (!subDirectories[i].Equals(11) && !subDirectories[i].Equals(12))
                        {
                            Directory.Delete(subDirectories[i]);
                        }
                    }
                }
            }
        }



    }
}