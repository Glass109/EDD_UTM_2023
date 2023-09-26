import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Test {

    int[][] _matrix = new int[3][4];

    public static String[] UserInputArray() {
        System.out.println("Ingrese la cantidad de expresiones a introducir (n)");
        Scanner SCANNER = new Scanner(System.in);
        int dimensiones = Integer.parseInt(SCANNER.nextLine());
        String[] userImput = new String[dimensiones];

        for (int i = 0; i < dimensiones; i++) {
            System.out.println("Ingrese expresion #" + (i + 1) + " (FORMATO: 5x + y - 1z = 50r)");
            String exp = SCANNER.nextLine();
            userImput[i] = quitarEspacios(exp);
            if (userImput[i].isBlank()) {
                System.out.println("ALGO SALIÓ MAL, REGRESANDO NADA");
                SCANNER.close();
                return null;
            }
        }
        SCANNER.close();
        return userImput;
    }
    
    public static List<Integer> aMatrixRegex(String[] userImput){
        //
        //PATRON EXPRESIÓN REGULAR, REGEX, LO HICE ALCOHOLIZADO, NO PREGUNTAR
        //
        Pattern coeficientesPattern = Pattern.compile("([+-=]?\\d+)?([a-zA-Z])");
        //Matriz enteros
        List<Integer> matrizInt = new ArrayList<>();
        for (int i = 0; i < userImput.length; i++) {
            Matcher matcher = coeficientesPattern.matcher(userImput[i]);
            // Guarda los 9 cocientes en 3 arrays
            Integer[] coeficientesInt = new Integer[4];
            while (matcher.find()) {
                int counter = 0;
                String coeficientesStr = matcher.group(1);
                // String letras = matcher.group(2); // Por si acaso
                // Intenta traducir de String a Int, introduce 1 si está vacio para evitar poner
                // 1X en vez de solo X
                coeficientesInt[counter] = quitarSimbolos(coeficientesStr);
                
                // System.out.print("{" + coeficientesInt[0] + "}");
                // System.out.print(letras + " ");

                matrizInt.add(coeficientesInt[counter]);
                counter++;
            }
            System.out.println("");
        }
        return matrizInt;
    }
    // +2 -> 2, -4 -> -4, =5 -> 5
    public static int quitarSimbolos(String str){
        if (str == null || str.isBlank()) {
            return 1;
        }
        if (str.contains("+") || str.contains("=")){
            return Integer.parseInt(str.substring(1));
        }
        if (str.equals("-")){
            return -1;
        }
        return Integer.parseInt(str);
    }
    //Creo que no lo usé jsdjkadjsak
    public static Boolean esNumerico(String str){
        return str.matches("-?\\d+");
    }

    public static String quitarEspacios(String s) {
        String _s = s.replaceAll("\\s", "");
        System.out.println(_s);
        return _s;
    }

    public static int[][] arregloCuatroTercios(List<Integer> l){
        int contador = 0;
        int raiz = (int) Math.sqrt(l.size());
        int[][] matriz = new int[raiz][raiz+1];
        for (int i = 0; i < raiz; i++) {
            for (int j = 0; j < raiz+1; j++) {
                matriz[i][j] = l.get(contador);
                contador++;
            }
        }
        return matriz;
    }
    public static void CalculoGaussJordan(int[][] matrix){
        int numFilas = matrix.length;
        int numColumnas = matrix[0].length;

        // Perform Gauss-Jordan elimination
        for (int filaAncla = 0; filaAncla < numFilas; filaAncla++) {
            // Find the pivot element (the element at pivotRow, pivotRow)
            double ancla = matrix[filaAncla][filaAncla];

            // Make the pivot element equal to 1 by dividing the whole row by the pivot
            for (int j = filaAncla; j < numColumnas; j++) {
                matrix[filaAncla][j] /= ancla;
            }

            // Make other rows zero in the pivot column
            for (int i = 0; i < numFilas; i++) {
                if (i != filaAncla) {
                    double factor = matrix[i][filaAncla];
                    for (int j = filaAncla; j < numColumnas; j++) {
                        matrix[i][j] -= factor * matrix[filaAncla][j];
                    }
                }
            }
        }
        // Print the solution

        System.out.println(Arrays.deepToString(matrix));
        for (int i = 0; i < numFilas; i++) {
            System.out.print("x" + (i + 1) + " = " + matrix[i][numColumnas - 1] + "\n");
        }
    }
}