namespace CalcultorProject.Models
{
    public class CalcModel
    {
        public double num1 {get; set;}
        public double num2 { get; set;}
        public string addingthing { get; set;}
        public double Result { get; set;}

        public double Calculate()
        {
            switch (addingthing)
            {
                case "+":
                    return num1+num2;
                case "-":
                    return num1-num2;
                case "*":
                    return num1*num2;
                case "/": 
                    return num1/num2;
                default: return 0;


            }
        }


    }
}
