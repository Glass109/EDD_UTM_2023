import java.util.ArrayList;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Test {
    public static void main(String[] args) {
        String inputString = "50x+40y-1z=10";
        String pattern = "([+-]?\\d+)([a-zA-Z])";

        Pattern regexPattern = Pattern.compile(pattern);
        Matcher matcher = regexPattern.matcher(inputString);

        List<Integer> coefficients = new ArrayList<>();
        List<String> variables = new ArrayList<>();

        while (matcher.find()) {
            String coefficientStr = matcher.group(1);
            String variable = matcher.group(2);

            int coefficient = (coefficientStr.isEmpty() || coefficientStr.equals("+")) ? 1 : Integer.parseInt(coefficientStr);
            coefficients.add(coefficient);
            variables.add(variable);
        }

        System.out.println("Coefficients: " + coefficients);
        System.out.println("Variables: " + variables);
    }
}