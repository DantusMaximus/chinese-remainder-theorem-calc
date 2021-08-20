namespace KinesiskaRestsatsen{
    static public class Input{
        static public bool Valid(char input){
            if(input == 'y'){ return true;}
            if(input == 'n'){ return true;}
            return false;
        }
    }
}