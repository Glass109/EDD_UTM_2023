import java.util.Scanner;

public class Matrix {
    public static int[][] crearMatrix() {
        int[][] defaultMatrix = {
            {2, 1, -1, 8},
            {-3, -1, 2, -11},
            {-2, 1, 2, -3}
        };

        System.out.println("Ingrese una dimensión de la matriz (n * n) [PRESIONE D para DEFAULT MATRIX]");
        Scanner SCANNER = new Scanner(System.in);
        String a = SCANNER.nextLine();
        if(a.contains("D")){
            return defaultMatrix;
        }
        int dimensiones;
        try {
            dimensiones = Integer.parseInt(a);
        } catch (Exception e) {
            System.out.println("ERROR, DEFAULT a 3");
            dimensiones = 3;
        }
        int[][] matrix = new int[dimensiones][dimensiones];
        // SCANNER.close();
        return matrix;
    }

    public static int[][] rellenar(int[][] matrix) {
        
        Scanner scanner = new Scanner(System.in);
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[0].length; j++) {
                System.out.print("ingrese dato para el espacio [" + i + "][" + j + "]: ");
                try {
                    matrix[i][j] = Integer.parseInt(scanner.nextLine());
                } catch (Exception e) {
                    System.out.println("Error, default a 0");
                    matrix[i][j] = 0;
                }
            }
        }
        scanner.close();
        return matrix;
    }

    public static void contarCeros(int[][] matrix) {
        int ceros = 0;
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[0].length; j++) {
                if(matrix[i][j] == 0) ceros++;
            }
            System.out.println("# de Ceros en Fila " + i + ": " + ceros);
            ceros = 0;
        }
    }

    public static int[][] aplicarGaussJordan(int[][] matrix){

        int rows = matrix.length;
        int cols = matrix[0].length;
        for (int i = 0; i < rows; i++) {
            double pivot = matrix[i][i];
            for (int j = 0; j < cols; j++) {
                matrix[i][j] /= pivot;
            }
            for (int k = 0; k < rows; k++) {
                if (k != i) {
                    double factor = matrix[k][i];
                    for (int j = 0; j < cols; j++) {
                        matrix[k][j] -= factor * matrix[i][j];
                    }
                }
            }
        }
        return matrix;
    }
}