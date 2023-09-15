public class Emecede {
    int _n1;
    int _n2;
    public Emecede(int n1, int n2){
        _n1 = n1;
        _n2 = n2;
        
    }
    public int Calculo(){
        int resto = _n1 % _n2;
        if(resto == 0){
            return _n2;
        }
        _n1 = _n2;
        _n2 = resto;
        return Calculo();
    }
}