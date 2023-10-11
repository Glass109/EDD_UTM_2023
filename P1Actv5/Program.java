import java.util.Scanner;

public class Program{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        while (true){
            System.out.println("SELECCIONE NUMERO DE EJERCICIO (1-4)");
            try {
                int op = Integer.parseInt(scanner.nextLine());
            } catch (Exception e) {
                System.out.println("ERROR");
                return;
            }
            switch(op){
                case 1:
                break;
            }
            
        }
    }
}