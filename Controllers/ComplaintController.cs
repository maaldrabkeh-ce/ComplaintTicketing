using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace ComplaintTicketing.Controllers
{
    public class ComplaintController : Controller
    {
        [HttpGet]
        public ComplaintViewModel Index()
        {
            ComplaintViewModel viewModel = new ComplaintViewModel();
            return viewModel;
        }

        // POST: ComplaintController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public bool Create(ComplaintViewModel viewModel)
        {
            try
            {
                // Process viewModel and save data
                return true;
            }
            catch
            {
                return false;
            }
        }


        // POST: ComplaintController/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        public bool Edit(ComplaintViewModel viewModel)
        {
            try
            {
                // Process viewModel and save data
                return true;
            }
            catch
            {
                return false;
            }
        }


        // POST: ComplaintController/Delete/5
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public bool Delete(Guid id)
        {
            try
            {
                // Process viewModel and delete data
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPost("save")]
        public async Task<IActionResult> SavePdf()
        {
            try
            {
                byte[] pdfContent = GeneratePdf();

                string filePath = "path/to/save/pdf.pdf"; 
                await System.IO.File.WriteAllBytesAsync(filePath, pdfContent);

                return Ok(new { message = "PDF saved successfully", filePath });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An error occurred while saving the PDF", details = ex.Message });
            }
        }

        private byte[] GeneratePdf()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write("Sample PDF Content");
                    writer.Flush();
                    stream.Position = 0;
                    return stream.ToArray();
                }
            }
        }
    }
}
