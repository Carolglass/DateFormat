//Solución de los profesores con modificaciones

namespace DateFormat
{
    public class Format2 
    {
        public Format2(string year)
        {
            this.Year=year;
        }

        public string Year {get; set;}

        public String ChangeFormat2()
        {
            if (this.Year=="")
            {
                return "-";
            } 
            else 
            {
                return this.Year.Substring(6) + "-" + this.Year.Substring(3, 2) + "-" + this.Year.Substring(0, 2);
            }
           
        }
        
    }
}

