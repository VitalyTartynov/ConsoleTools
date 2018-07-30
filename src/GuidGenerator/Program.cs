// /****************************** generate_guid ******************************\
// Project:            generate_guid
// Filename:           Program.cs
// Created:            09.10.2016
// 
// <summary>
// Простейшая консольная команда, создающая новый GUID и копирующая его в буфер обмена
// </summary>
// \***************************************************************************/

using System;
using System.Windows.Forms;

namespace GuidGenerator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            
            Clipboard.SetText(id.ToString());
            Console.WriteLine($"Guid copied to clipboard: {id}");
        }
    }
}
