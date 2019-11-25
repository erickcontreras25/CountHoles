namespace CountHolesKata
{
    public class CountHoles
    {
        public int number { get; set; }

        public int holes;

        public CountHoles()
        {
            
        }

        public CountHoles(int value)
        {

            while(value > 0){
                int aux = value%10;

                if(aux==0 | aux==4 | aux==6 | aux==9 ){
                    holes = 1;
                }else if(aux==1 | aux==2 | aux==3 | aux==5 | aux==7){
                    holes = 0;
                }else if(aux == 8){
                    holes = 2;
                }
                number += holes;

                value /= 10;
            }
        }
    }
}