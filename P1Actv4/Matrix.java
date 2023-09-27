import java.util.Scanner;
public class Matrix {

    public static int[][] crearMatrix() {
        System.out.println("Ingrese una dimensión de la matriz (n * n)");
        Scanner SCANNER = new Scanner(System.in);
        int dimensiones = Integer.parseInt(SCANNER.nextLine());
        int[][] matrix = new int[dimensiones][dimensiones];
        // SCANNER.close();
        return matrix;
    }
    public static int[][] rellenar(int[][] matrix) {
        Scanner scanner = new Scanner(System.in);
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[0].length; j++) {
                System.out.println("ingrese dato para el espacio [" + i + "][" + j + "]");
                matrix[i][j] = Integer.parseInt(scanner.nextLine());
            }
        }
        scanner.close();
        return matrix;
    }
    
}