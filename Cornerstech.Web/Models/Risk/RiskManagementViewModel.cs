namespace Cornerstech.Web.Models.Risk
{
    public class RiskManagementViewModel
    {

        public Dictionary<double, string> LevelDescriptions { get; set; }
        public Dictionary<double, string> FrequenceDescriptions { get; set; }
        public Dictionary<double, string> PossibilityDescriptions { get; set; }

    }
}
