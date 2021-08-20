namespace KinesiskaRestsatsen{
    static public class Input{
        static public bool Valid(char input){
            if(input == '1'){ return true;}
            if(input == '0'){ return true;}
            return false;
        }
    }
}