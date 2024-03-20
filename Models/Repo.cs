using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BtkAkademi.Models
{
    public static class Repo
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;
        
        public static void Apply(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}