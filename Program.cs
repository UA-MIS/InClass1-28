using System;

namespace TAsSec2
{
    class Program
    {
        static void Main(string[] args)
        {
            // TA kera = new TA(){Name = "Kera"};

            // kera.GradeBehavior.Grading();
            // kera.GradeBehavior = new MultipleChoiceGrading();
            // kera.GradeBehavior.Grading();

            PAGrader kera = new PAGrader(){Name = "Kera"};

            kera.Grade();
            kera.WorkOfficeHours();
        }
    }
}
