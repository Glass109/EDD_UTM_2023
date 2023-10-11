import java.util.Arrays;

public class Program {

    public static void main(String[] args) {
        int[][] defaultMatrix = {
            {2, 1, -1, 8},
            {-3, -1, 2, -11},
            {-2, 1, 2, -3}
        };

        int[][] _matrix = Matrix.crearMatrix(); //Obtener un Array de lo escrito por el usuario
        if(!Arrays.deepEquals(defaultMatrix, _matrix))
            _matrix = Matrix.rellenar(_matrix);
        System.out.println(Arrays.deepToString(_matrix).replace("],","\n")); //Imprime la matriz
        Matrix.contarCeros(_matrix);
        System.out.println(Arrays.deepToString(Matrix.aplicarGaussJordan(_matrix)).replace("],","\n")); //Imprime la matriz
    }
}