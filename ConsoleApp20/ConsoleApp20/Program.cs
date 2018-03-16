using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 11ci sualin cavabi:
             * intheranc miras demekdi, bunu c# da isi daha asan yerine yetirmek ucun isdifade edirler,
             * meselen lamorgini masinini yaradanda her ibyekt ucun her defe ayri bi sinif yaradib yeniden onu isdifade etmek evezine
             * 1 defe sinif yaradib teze yaranan sinife miras buraxiriq belece her defe hedden artiq kod yazmaga ehtiyyac qalmir,
             * hedden artiq yazilan kodu idare etmek de cetindi cinki gelecekde hansisa xirda bir detali deyisende gerekn butun yaranmis siniflerdeki 
             * propertileri, methodlari deyishesen, bunun evezine intherance yolu ile miras goturulen sinifde deyisiklik etmekle problemi daha asan 
             * hell elemek mumkun olur.*/

            /* 12ci sualin cavabi:
             * C# bir nece miras usulunu destekliyir, ancaq her defe yeni yaranan sinif ozunden 1 defe evvel yaranmis sinifi miras almaqla
             * bu ish heyata kecirilir, ola biler ki yeni yaranan bir sinif ozunde 1 evvel yaranmis sinifi yox 2 3 nesil evvel yaranmis sinifi bir basa 
             * miras alsin. Evvel yaranmis sinif yeni yaranmis sinifi miras ala bilmez o yalniz miras oturule biler. */

             


        }
        class Baba
        {

        }
        class Ata:Baba
        {

        }
        class Neve : Baba
        {

        }
        //class Neve : Ata
        //{

        //} 
                    /*13cu sualin cavabi: C# da her yaranan yeni sinif ozunden evvel yaranmis sinifi bu yolla miras alir:  */

    }
    




    
}
