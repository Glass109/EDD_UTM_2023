import java.util.Scanner;

public class Program{ 

    public static void main(String[] args) {
        
        Matricez matrix = new Matricez();
        Scanner scanner = new Scanner(System.in);
        
        while(true){
            System.out.print("1. SUMA \n2. RESTA \n3. MULTI \n4. DIV \n5. EXIT \n");
            switch(scanner.next()){
                case "1":
                    matrix.Suma();
                    break;
                case "2":
                    matrix.Resta();
                    break;
                case "3":
                    matrix.Multi();
                    break;
                case "4":
                    matrix.Div();
                    break;
                case "5":
                    scanner.close();
                    return;
            }
        }
        
    }
}