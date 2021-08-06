using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace AsposeMemoryRepro
{
    class Program
    {
        static void Main()
        {
            // You need to add license file to the project and set it as an embedded resource for this to work
            var license = new License();
            license.SetLicense("Aspose.Total.NET.lic");

            // Note: the severity of the memory leak depends A LOT on the PDF used.
            // I am not sure why this is.
            var filename = "TestFile.pdf";
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            using var pdf = new Document(path);

            for (var pageNumber = 1; pageNumber <= pdf.Pages.Count; pageNumber++)
            {
                var page = pdf.Pages[pageNumber];

                var textAbsorber = new TextAbsorber();

                // Comment out this line and there will be no memory leak
                page.Accept(textAbsorber);

                if (pageNumber % 20 == 0)
                {
                    // Force garbage collection to get a more accurate estimate of the total bytes allocated
                    GC.Collect();
                    var bytesAllocated = GC.GetTotalMemory(true);
                    Console.WriteLine($"Page {pageNumber}: {bytesAllocated / 1000000} MB allocated");
                }
            }
        }
    }
}
