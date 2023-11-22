using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.SOLID
{
    /*interface IFormatter
    {
        void ToExcel();
        void ToPdf();
    }*/

    interface IExcelFormatter
    {
        void ToExcel();
    }
    interface IPdfFormatter
    {
            void ToPdf();
    }

    class Report : IPdfFormatter, IExcelFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Excel generated");
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    class Poem : IPdfFormatter
    {
        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

}
