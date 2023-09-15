import java.util.Scanner;

public class Program {
    public static final String COLOR_CYAN = "\u001B[36m";
    public static final String COLOR_RESET = "\u001B[0m";
    public static final String COLOR_ROJO = "\u001B[31m";

    Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        Menu();

    }

    public static void Menu() {
        int numeroUno = 0, numeroDos = 0, resultado = 9;

        Scanner scanner = new Scanner(System.in);
        System.out.println(COLOR_CYAN + "¿Que tipo de calculadora quieres usar?" + COLOR_RESET);
        System.out.println("1. Potencia");
        System.out.println("2. Factorial");
        System.out.println("3. Fibonacci");
        System.out.println("4. Hanoi");
        System.out.println("5. Máximo Común Divisor");
        String op = scanner.nextLine();

        System.out.print("Ingresa el valor #1: ");
        numeroUno = Integer.parseInt(scanner.nextLine());

        if (op.equals("1") || op.equals("5")) {
            System.out.print("Ingresa el valor #2: ");
            numeroDos = Integer.parseInt(scanner.nextLine());
        }

        switch (op) {
            case "1":
                Potencia calcPotencia = new Potencia(numeroUno, numeroDos);
                resultado = calcPotencia.Calculo();
                System.out.println(COLOR_ROJO + "El resultado es: " + resultado + COLOR_RESET);
                break;
            case "2":
                Factorial calcFactorial = new Factorial();
                resultado = calcFactorial.Calculo(numeroUno);
                System.out.println(COLOR_ROJO + "El resultado es: " + resultado + COLOR_RESET);
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
                System.out.println(COLOR_ROJO + "El MCD es: " + resultado + COLOR_RESET);
                break;
            default:
                break;
        }
        Menu();
        scanner.close();
    }
}
