using System.IO;
using FastReport;
using FastReport.Export.Pdf;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoExternalNugetRefVsCode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetReport()
        {
            // Create report instance.
            Report report = new Report();

            // Load the existing report.
            report.Load("Report/Test.frx");

            // Prepare the report.
            report.Prepare();

            // Create export instance
            PDFExport export = new PDFExport();

            // Transform result and return to client.
            using (MemoryStream ms = new MemoryStream())
            {
                report.Export(export, ms);1
                ms.Flush();
                return File(ms.ToArray(), "application/pdf", Path.GetFileNameWithoutExtension("Test") + ".pdf");
            }
        }
    }
}