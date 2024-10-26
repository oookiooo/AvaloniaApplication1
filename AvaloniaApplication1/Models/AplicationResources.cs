using Avalonia;
using AvaloniaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Models
{
    internal class AplicationResources
    {
        public static string ApiUrl = "https://localhost:44397/";
        public static User userActuallyLogin => (Application.Current as App)?.UserModel;
    }
}
