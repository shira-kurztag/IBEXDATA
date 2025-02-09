using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace IBEXDATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly string[] permittedExtensions = { ".zip", ".rar" };
        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                _logger.LogWarning("File is not selected or empty");
                return BadRequest("לא נבחר קובץ או שהקובץ ריק");
            }

            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            _logger.LogInformation("File extension: {Extension}", extension);

            if (string.IsNullOrEmpty(extension) || !permittedExtensions.Contains(extension))
            {
                _logger.LogWarning("Invalid file type: {Extension}", extension);
                return BadRequest("סוג הקובץ אינו נתמך. ניתן להעלות רק קבצי ZIP או RAR");
            }

            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
            if (!Directory.Exists(uploadPath))
            {
                _logger.LogInformation("Creating upload directory at {UploadPath}", uploadPath);
                Directory.CreateDirectory(uploadPath);
            }

            var filePath = Path.Combine(uploadPath, file.FileName);
            _logger.LogInformation("Saving file to {FilePath}", filePath);

            try
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while saving file");
                return StatusCode(500, "שגיאה בעת שמירת הקובץ");
            }

            return Ok(new { filePath });
        }
    }
}