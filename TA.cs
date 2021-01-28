namespace TAsSec2
{
    public abstract class TA
    {
        public string Name { get; set; }

        public abstract void Grade();

        public void WorkOfficeHours(){
            System.Console.WriteLine("I am in office hours.");
        }

        // public IGrade GradeBehavior {get; set;}

        // public TA(){
        //     GradeBehavior = new Grade();
        // }


        // public void Grade(string type){
        //     if(type == "multiple choice"){
        //         System.Console.WriteLine("I am grading muliple choice");
        //     }
        //     else{
        //         System.Console.WriteLine("I am grading.");
        //     }
        // }
    }
}