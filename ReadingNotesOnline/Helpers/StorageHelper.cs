using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace ReadingNotesOnline.Helpers
{
    public class StorageHelper
    {

        private static CloudStorageAccount AzureStorage()
        {
            return CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);
        }


        private static CloudBlobClient BlobClient()
        {
            CloudStorageAccount storageAccount = AzureStorage();
            return storageAccount.CreateCloudBlobClient();
        }


        public static List<Models.BasicBlobInfo> GetFilesInContainer(string containerName) {

            CloudBlobClient blobClient = BlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference(containerName);

            var blobs = container.ListBlobs(null, false);
            var drafts = new List<Models.BasicBlobInfo>();

            foreach (var blobItem in blobs)
            {
                string filename = ExtractFileNameFromBlobPath(blobItem, containerName);
                drafts.Add(new Models.BasicBlobInfo { FileName = filename });
            }
      
            return drafts;
        }

        private static string GetJSonReadingNotesContainerName()
        {
            return ConfigurationManager.AppSettings["JSonReadingNotesContainerName"];
        }

        public static Stream GetStreamFromStorage(string ContainerName, string Filename)
        {
            var blobClient = BlobClient();
            var container = blobClient.GetContainerReference(ContainerName);
            var blockBlob = container.GetBlockBlobReference(Filename);

            using (var memoryStream = new MemoryStream())
            {

                blockBlob.DownloadToStream(memoryStream);
                byte[] byteArray = memoryStream.ToArray();

                MemoryStream stream = new MemoryStream(byteArray);
                return stream;
            }

        }


        public static string ExtractFileNameFromBlobPath(IListBlobItem blobItem, string containerName)
        {
            // This was required because System.IO.Path.GetFileName failled with special caracters
            return blobItem.Uri.LocalPath.Replace(string.Concat("/", containerName, "/"), "");
        }


        public static string SaveJSonReadingNotesToStorage(string JSonReadingNotes, string filename)
        {

            var blobClient = BlobClient();
            var container = blobClient.GetContainerReference(GetJSonReadingNotesContainerName());

            //var filename = "readingnotes_" + DateTime.Now.ToString("yyyy-MM-dd") + ".json";
            var blockBlob = container.GetBlockBlobReference(filename);
            blockBlob.UploadText(JSonReadingNotes);

            return filename;

        }


        public static string GetJSonReadingNotes(string Filename)
        {

            string notesData = string.Empty;
            var stream = GetStreamFromStorage(GetJSonReadingNotesContainerName(), Filename);

            using (var sr = new System.IO.StreamReader(stream))
            {
                notesData = sr.ReadToEnd();
            }
            return notesData;
        }
    }
}