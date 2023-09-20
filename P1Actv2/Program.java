import java.util.Scanner;
@SuppressWarnings("unused")
public class Program {
    //Colores de texto, no son tan necesariso
    public static final String ANSI_RESET = "\u001B[0m";
    public static final String ANSI_BLACK = "\u001B[30m";
    public static final String ANSI_RED = "\u001B[31m";
    public static final String ANSI_GREEN = "\u001B[32m";
    public static final String ANSI_YELLOW = "\u001B[33m";
    public static final String ANSI_BLUE = "\u001B[34m";
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_CYAN = "\u001B[36m";
    public static final String ANSI_WHITE = "\u001B[37m";

    Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        Menu();
        

    }

    public static void Menu() {
        int numeroUno = 0, numeroDos = 0, resultado = 9;
        String textNumeroUno, textNumeroDos;

        Scanner scanner = new Scanner(System.in);
        System.out.println(ANSI_CYAN + "¿Que tipo de calculadora quieres usar?" + ANSI_RESET);
        System.out.println("1. Potencia");
        System.out.println("2. Factorial");
        System.out.println("3. Fibonacci");
        System.out.println("4. Hanoi");
        System.out.println("5. Máximo Común Divisor");
        System.out.println("6. Cambio");

        String op = scanner.nextLine();

        System.out.print("Ingresa el valor #1: ");
        textNumeroUno = scanner.nextLine();

        if(!op.equals("6"))
        numeroUno = (int) Float.parseFloat(textNumeroUno);
        

        if (op.equals("1") || op.equals("5")) {
            System.out.print("Ingresa el valor #2: ");
            textNumeroDos = scanner.nextLine();
            numeroDos = (int) Float.parseFloat(textNumeroDos);
        }

        switch (op) {
            case "1":
                Potencia calcPotencia = new Potencia(numeroUno, numeroDos);
                resultado = calcPotencia.Calculo();
                System.out.println(ANSI_RED + "El resultado es: " + resultado + ANSI_RESET);
                break;
            case "2":
                Factorial calcFactorial = new Factorial();
                resultado = calcFactorial.Calculo(numeroUno);
                System.out.println(ANSI_RED + "El resultado es: " + resultado + ANSI_RESET);
                break;
            case "3":
                Fibonacci FIB = new Fibonacci();
                FIB.calcularFibonacci(numeroUno);
                break;

            case "4":
                TowerOfHanoi TOH = new TowerOfHanoi(numeroUno);
                break;

            case "5":
                Emecede MCD = new Emecede(numeroUno, numeroDos);
                resultado = MCD.Calculo();
                System.out.println(ANSI_RED + "El MCD es: " + resultado + ANSI_RESET);
                break;
            // case "6":
            //     Cambio MDC = new Cambio();
            //     try {
            //         MDC.CalcularCambio(Float.parseFloat(textNumeroUno));
            //     } catch (Exception e) {
            //         System.out.println("ERROR:" + e);
            //     }
            //     break;
            default:
                break;
        }
        Menu();
        scanner.close();
    }
}
