using System.Windows;
using System.Windows.Forms;

namespace ClipDate
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DateTime currentDate = DateTime.Now;
            string dateText = currentDate.ToString("yyyy-MM-dd HH:mm:ss");

            Clipboard.SetText(dateText);
        }
    }
}