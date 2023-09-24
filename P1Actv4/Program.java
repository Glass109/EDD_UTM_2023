import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Program {

    public Program() {
        super();
    }
    public static String quitarEspacios(String s){
        String _s = s.replaceAll("\\s","");
        System.out.println(_s);
        return _s;
    }

    public static void main(String[] args) {
        int[][] matrix = new int[3][4];

        for (var a : ) {
            
        }

        Pattern coeficientesPattern = Pattern.compile("([+-]?\\d+)?([a-zA-Z])");
        Pattern resultadoPattern = Pattern.compile("(=)(\\d)");
        Scanner scn = new Scanner(System.in);

        String[] expresiones = new String[3];

        

        for (int i = 0; i < 3; i++) {
            
            System.out.println("Ingrese expresion #" + (i+1) + " (FORMATO: 5x-5y-1z=50)");
            String exp = scn.nextLine();
            expresiones[i] = Program.quitarEspacios(exp);
            if(expresiones[i].isBlank()){
                System.out.println("ALGO SALIÓ MAL, REINICIANDO");
                main(args);
                scn.close();
                return;
            }
        }

        for (int i = 0; i < expresiones.length; i++) {
            Matcher matcher = coeficientesPattern.matcher(expresiones[i]);
            //Guarda los 9 cocientes en 3 arrays

            while (matcher.find()) {
                String coeficientesStr = matcher.group(1);
                String letras = matcher.group(2);

                //Intenta traducir de String a Int, introduce 1 si está vacio para evitar poner 1X en vez de solo X
                int coeficientesInt = 
                    (coeficientesStr == null) ? 1
                    :(coeficientesStr.isEmpty() || coeficientesStr.equals("+")) ? 1 
                    :(coeficientesStr.equals("-")) ? -1
                    :Integer.parseInt(coeficientesStr); 

                
                System.out.print(coeficientesInt);
                System.out.print(letras + " ");

            }
            matcher = resultadoPattern.matcher(expresiones[i]);
            
            System.out.println("");

        }


        scn.close();

    }   
    
}