using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureVirtualDesktop
{
    class response_data_list_properties_form
    {
        public string description { get; set; }
        public string friendlyName { get; set; }
        public string filePath { get; set; }
        public string commandLineSetting { get; set; }
        public string commandLineArguments { get; set; }
        public bool showInPortal { get; set; }
        public string iconPath { get; set; }
        public int iconIndex { get; set; }
        public string iconHash { get; set; }
        public string iconContent { get; set; }
        public string applicationType { get; set; }
        public string msixPackageFamilyName { get; set; }
        public string msixPackageApplicationId { get; set; }
        public string objectId { get; set; }
    }
    class response_data_list_form
    {
        public string name { get; set; }
        public string id { get; set; }
        public string type { get; set; }

        public response_data_list_properties_form properties { get; set; }
    }
    class response_data_form
    {
        public List<response_data_list_form> value { get; set; }
        public string nextLink { get; set; }

    }
}
