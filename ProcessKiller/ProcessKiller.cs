//Версия библиотеки 1.0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//что я добавил
using System.Diagnostics;

namespace ProcessKiller
{
    public class Proces
    {

        //убить процесс

        public static void Kill(string name)
        {

            Process[] proces = Process.GetProcesses();//получаем все процессы

            foreach (Process nameprocess in proces)//подбираем все процессы
            {
                try
                {
                    if (name == nameprocess.ProcessName)//если нашли, то
                    {
                        nameprocess.Kill();//убиваем его ;)
                    }
                    else
                    {

                    }
                }
                catch
                {

                }
            }
        }
    }
}
