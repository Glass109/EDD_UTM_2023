import java.util.Arrays;
import java.util.List;

public class Program {

    public static void main(String[] args) {
        
        String[] respuestasArray = Test.UserInputArray(); //Obtener un Array de lo escrito por el usuario
        List<Integer> listaCocientes = Test.aMatrixRegex(respuestasArray); //Extraer los cocientes con Regex
        // System.out.println("Listacocientes" + listaCocientes);  //
        int[][] matriz = Test.arregloCuatroTercios(listaCocientes);
        // System.out.println("Matriz:" + Arrays.deepToString(matriz));
        Test.CalculoGaussJordan(matriz);

    }

}