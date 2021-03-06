using System;

namespace Magpie.Services
{
    public class AppInfo
    {
        public string AppIconPath { get; set; }
        public string AppCastUrl { get; set; }

        public void SetAppIcon(string imageNamespace, string imagePath)
        {
            AppIconPath = string.Format("pack://application:,,,/{0};component/{1}", imageNamespace, imagePath);
        }

        public AppInfo(string appCastUrl)
        {
            if (string.IsNullOrWhiteSpace(appCastUrl))
            {
                throw new ArgumentNullException("appCastUrl");
            }
            AppCastUrl = appCastUrl;
        }
    }
}