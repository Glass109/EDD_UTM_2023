import java.util.Scanner;

public class Matricez {

    double[][] matrix1 = {
            { 2, 4 },
            { 6, 8 }
    };

    double[][] matrix2 = {
            { 3, 5 },
            { 7, 9 }
    };
    
    public Scanner scanner = new Scanner(System.in);

    public Matricez() {

    }

    public double Suma() {
        for (double[] a : matrix1) {
            for (double d : a) {
                System.out.print(" (" + d + ") ");
            }
            System.out.print("\n"); // Salto de linea al final de cada fila
        }
        System.out.println("\n + \n");

        for (double[] a : matrix2) {
            for (double d : a) {
                System.out.print(" (" + d + ") ");
            }
            System.out.print("\n"); // Salto de linea al final de cada fila

        }
        System.out.println("\n = \n");

        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                System.out.print(" (" + (matrix1[i][j] + matrix2[i][j]) + ") ");
            }
            System.out.print("\n");
        }
        scanner.next();
        return 1;
    }

    public double Resta() {
        for (double[] a : matrix1) {
            for (double d : a) {
                System.out.print(" (" + d + ") ");
            }
            System.out.print("\n"); // Salto de linea al final de cada fila
        }
        System.out.println("\n - \n"); // Signo

        for (double[] a : matrix2) {
            for (double d : a) {
                System.out.print(" (" + d + ") ");
            }
            System.out.print("\n"); // Salto de linea al final de cada fila

        }
        System.out.println("\n = \n");

        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                System.out.print(" (" + (matrix1[i][j] - matrix2[i][j]) + ") ");
            }
            System.out.print("\n");
        }
        scanner.next();
        return 1;
    }

    public double Div() {
        for (double[] a : matrix1) {
            for (double d : a) {
                System.out.print(" (" + d + ") ");
            }
            System.out.print("\n"); // Salto de linea al final de cada fila
        }
        System.out.println("\n / \n"); // Signo

        for (double[] a : matrix2) {
            for (double d : a) {
                System.out.print(" (" + d + ") ");
            }
            System.out.print("\n"); // Salto de linea al final de cada fila

        }
        System.out.println("\n = \n");

        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                System.out.print(" (" + (matrix1[i][j] / matrix2[i][j]) + ") ");
            }
            System.out.print("\n");
        }
        scanner.next();
        return 1;
    }

    public double Multi() {
        for (double[] a : matrix1) {
            for (double d : a) {
                System.out.print(" (" + d + ") ");
            }
            System.out.print("\n"); // Salto de linea al final de cada fila
        }
        System.out.println("\n * \n"); // Signo

        for (double[] a : matrix2) {
            for (double d : a) {
                System.out.print(" (" + d + ") ");
            }
            System.out.print("\n"); // Salto de linea al final de cada fila

        }
        System.out.println("\n = \n");

        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                System.out.print(" (" + (matrix1[i][j] * matrix2[i][j]) + ") ");
            }
            System.out.print("\n");
        }
        scanner.next();
        return 1;
    }
}
