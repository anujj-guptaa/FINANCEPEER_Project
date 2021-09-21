using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
 
using System.Text.Json;
using Anuj_BlazorApp.Models;
using Newtonsoft.Json;

namespace Anuj_BlazorApp.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IWebHostEnvironment env { get; set; }
        public string file_Name { get; set; }
        public IList<DataModel> DataModels { get; set; }

        public  string Message = "No file(s) selected";
        IReadOnlyList<IBrowserFile> selectedFiles;

        public void OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();
            Message = $"{selectedFiles.Count} file(s) selected";
            this.StateHasChanged();
        }

        public async void OnSubmit()
        {
            foreach (var file in selectedFiles)
            {
                Stream stream = file.OpenReadStream();
                var path = $"{env.WebRootPath}\\{file.Name}";
                file_Name = "wwwroot/" + file.Name;
                FileStream fs = File.Create(path);
                await stream.CopyToAsync(fs);
                stream.Close();
                fs.Close();
            }
            Message = $"{selectedFiles.Count} file(s) uploaded on server";
            this.StateHasChanged();
            string json = System.IO.File.ReadAllText(file_Name);
            DataModels = JsonConvert.DeserializeObject<List<DataModel>>(json);

        }

        protected override void OnInitialized()
        {
            try
            {
                string json = System.IO.File.ReadAllText(file_Name);
                DataModels = JsonConvert.DeserializeObject<List<DataModel>>(json);
            }
            catch (Exception)
            {

                
            }
        }
    }
}
