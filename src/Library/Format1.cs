namespace DateFormat
{
    public class Format1 
    {
        public Format1(string date)
        {
            this.Date=date;
        }

        public string Date {get; set;}
        
        //Utiliza TDD para agregar un nuevo método de formateo de fecha que retorne la fecha en otro formato diferente al anterior 
        //(por ejemplo, DD-MM-YYYY).
        public string ChangeFormat1()
        {

            string newDate = "";
            if (this.Date=="")
            {
                return "-";
            } 
            else 
            {
                char [] ArregloDate=this.Date.ToArray();
                for (int i=0;i<this.Date.Length;i++)
                {
                    if (this.Date.Substring(i,1)=="/")
                    {
                        newDate+="-";
                    } else {
                        newDate+=this.Date.Substring(i,1);
                    }
                }
                return newDate;
            }

            string [] dateArray;
            string delimitador = "-";            
            dateArray = newDate.Split(delimitador);


            //Chequea que el mes esté entre 01 y 12
            /*if ((int Int32.Parse(dateArray[1])>= 12)&(int Int32.Parse(dateArray[1]>=1)))
            {
                return newDate;
            }
            else
            {
                return "Mes no es válido";
            }*/



        }

    }
}

