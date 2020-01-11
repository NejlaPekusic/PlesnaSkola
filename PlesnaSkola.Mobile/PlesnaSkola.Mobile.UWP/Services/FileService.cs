using PlesnaSkola.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlesnaSkola.Mobile.UWP.Services
{
    public class FileService : IFileService
    {
        public string GetStorageFolderPath()
        {
            return Windows.Storage.ApplicationData.Current.LocalFolder.Path;
        }
    }
}
