using System.ComponentModel.Design;
    
namespace P1Actv1;
partial class Form1
{
    // 0 ES RECTANGULO
    // 1 ES TRIANGULO
    // 2 ES CIRCULO
    // 3+ ES ERROR HEHE
    public int modoCalc = 0;   
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.Valor1 = new System.Windows.Forms.NumericUpDown();
        this.Valor2 = new System.Windows.Forms.NumericUpDown();
        this.Valor3 = new System.Windows.Forms.NumericUpDown();
        this.Resultado = new System.Windows.Forms.Label();
        this.TipoSeleccion = new System.Windows.Forms.ComboBox();
        this.Boton = new System.Windows.Forms.Button();
        this.Valor1Texto = new System.Windows.Forms.GroupBox();
        this.Valor2Texto = new System.Windows.Forms.GroupBox();
        this.Valor3Texto = new System.Windows.Forms.GroupBox();
        this.TipoTexto = new System.Windows.Forms.GroupBox();
        this.Valor1Texto.SuspendLayout();
        this.Valor2Texto.SuspendLayout();
        this.TipoTexto.SuspendLayout();
        this.SuspendLayout();
        //
        // Valor1
        //
        this.Valor1.Text =  "Test1";
        this.Valor1.Location = new System.Drawing.Point(20,120);
        this.Valor1.Width = 100;
        this.Valor1.DecimalPlaces = 3;
        this.Valor1.Maximum = 999999;
        //
        // Valor2
        //
        this.Valor2.Text =  "Test2";
        this.Valor2.Location = new System.Drawing.Point(140,120);
        this.Valor2.Visible = false;
        this.Valor2.Width = 100;
        this.Valor2.DecimalPlaces = 3;
        this.Valor2.Maximum = 999999;
        //
        // Valor3
        //
        this.Valor3.Text =  "Test3";
        this.Valor3.Location = new System.Drawing.Point(260,120);
        this.Valor3.TabIndex = 9;
        this.Valor3.Width = 100;
        this.Valor3.DecimalPlaces = 3;
        this.Valor3.Maximum = 999999;
        //
        // Resultado
        //
        this.Resultado.AutoSize =  true;

        
        this.Resultado.Text =  "Resultado: ...";
        this.Resultado.Location = new System.Drawing.Point(140,272);
        this.Resultado.Size = new System.Drawing.Size(100,20);
        this.Resultado.TabIndex = 2;
        //
        // TipoSeleccion
        //
        this.TipoSeleccion.BackColor = System.Drawing.SystemColors.Info;
        this.TipoSeleccion.ItemHeight = 15;
        this.TipoSeleccion.Text =  "Seleccione...";
        this.TipoSeleccion.Location = new System.Drawing.Point(120,48);
        this.TipoSeleccion.TabIndex = 3;
        this.TipoSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
        this.TipoSeleccion.Items.Add("Rectangulo");
        this.TipoSeleccion.Items.Add("Triangulo");
        this.TipoSeleccion.Items.Add("Circulo");
        this.TipoSeleccion.SelectedIndex = 0;
        this.TipoSeleccion.DropDownClosed += new System.EventHandler(TipoSeleccion_OnSelectedIndexChanged);
        this.TipoSeleccion.SelectedIndexChanged += new System.EventHandler(TipoSeleccion_OnSelectedIndexChanged);
        //
        // Boton
        //
        this.Boton.Text =  "Calcular";
        this.Boton.Location = new System.Drawing.Point(140,184);
        this.Boton.Width = 100;
        this.Boton.TabIndex = 4;
        this.Boton.Click += new System.EventHandler(Button4_Click);
        
        //
        // Valor1Texto
        //
        this.Valor1Texto.Text =  "Base";
        this.Valor1Texto.Location = new System.Drawing.Point((Valor1.Location.X - 10),104);
        this.Valor1Texto.Size = new System.Drawing.Size(120,44);
        this.Valor1Texto.TabIndex = 5;
        
        //
        // Valor2Texto
        //
        this.Valor2Texto.Text =  "Lado #2";
        this.Valor2Texto.Location = new System.Drawing.Point((Valor2.Location.X - 10),104);
        this.Valor2Texto.Size = new System.Drawing.Size(120,44);
        this.Valor2Texto.TabIndex = 6;
        this.Valor2Texto.Visible = false;
        //
        // Valor3Texto
        //
        this.Valor3Texto.Text =  "Altura";
        this.Valor3Texto.Location = new System.Drawing.Point((Valor3.Location.X - 10),104);
        this.Valor3Texto.Size = new System.Drawing.Size(120,44);
        this.Valor3Texto.TabIndex = 7;
        
        //
        // TipoTexto
        //
        this.TipoTexto.Text =  "Tipo Calculadora";
        this.TipoTexto.Location = new System.Drawing.Point(110,32);
        this.TipoTexto.Size = new System.Drawing.Size(140,48);
        this.TipoTexto.TabIndex = 8;
        //
        // Form
        //
        this.Size = new System.Drawing.Size(480,400);
        this.Text = "Calculadora Dondé";
        this.Controls.Add(this.Valor1);
        this.Controls.Add(this.Valor2);
        this.Controls.Add(this.Valor3);
        this.Controls.Add(this.Resultado);
        this.Controls.Add(this.TipoSeleccion);
        this.Controls.Add(this.Boton);
        this.Controls.Add(this.Valor1Texto);
        this.Controls.Add(this.Valor2Texto);
        this.Controls.Add(this.Valor3Texto);
        this.Controls.Add(this.TipoTexto);
        this.Valor1Texto.ResumeLayout(false);
        this.Valor2Texto.ResumeLayout(false);
        this.Valor3Texto.ResumeLayout(false);
        this.TipoTexto.ResumeLayout(false);
        this.ResumeLayout(false);
        this.AcceptButton = this.Boton;
    } 

    #endregion 

    // private System.Windows.Forms.TextBox Valor1;
    // private System.Windows.Forms.TextBox Valor2;
    // private System.Windows.Forms.TextBox Valor3;
    // Posiblemente inutiles, pero no quiero borrarlos por si acaso
    private System.Windows.Forms.NumericUpDown Valor1;
    private System.Windows.Forms.NumericUpDown Valor2;
    private System.Windows.Forms.NumericUpDown Valor3;
    private System.Windows.Forms.Label Resultado;
    private System.Windows.Forms.ComboBox TipoSeleccion;
    private System.Windows.Forms.Button Boton;
    private System.Windows.Forms.GroupBox Valor1Texto;
    private System.Windows.Forms.GroupBox Valor2Texto;
    private System.Windows.Forms.GroupBox Valor3Texto;
    private System.Windows.Forms.GroupBox TipoTexto;

    //
    //  Funcion del Event Listener cuando se cierra el DropDown
    //
    private void TipoSeleccion_OnSelectedIndexChanged(Object sender, EventArgs e){
        string textCombo = "";
        if(TipoSeleccion.SelectedItem.GetType() != null){
            textCombo = TipoSeleccion.SelectedItem.ToString();
        }
        switch(textCombo){
            case "Rectangulo":
                ChangeValueText(ref sender,"Base","","Altura");
                ChangeValueVisibility(true,false,true);
                modoCalc = 0;
                break;
            case "Triangulo":
                ChangeValueText(ref sender,"Lado #1","Lado #2","Lado #3");
                ChangeValueVisibility(true,true,true);
                modoCalc = 1;
                break;
                
            case "Circulo":
                ChangeValueText(ref sender,"","Radio","");
                ChangeValueVisibility(false,true,false);
                modoCalc = 2;
                break;
            default:
                Resultado.Text = "ERROR";
                break;  
        }
        Resultado.Text = textCombo;
    }

    //
    //  Funcion del Event Listener cuando se presiona el Botón "Calcular"
    //
    private void Button4_Click(Object sender, EventArgs e)
    {
    
        Calcular(Valor1.Value, Valor2.Value, Valor3.Value);
    }

    private void Calcular(decimal val1, decimal val2, decimal val3){
        switch(modoCalc){
            //
            //  Calculo Rectangulo
            //
            case 0:
                Resultado.Text = "Area: "+ (val1 * val3) + "\nPerímetro: " + (2 * (val1 + val3));
            break;
            //
            //  Calculo Triangulo
            //
            case 1:
                decimal[] victor = {val1,val2,val3};
                Array.Sort(victor);
                if(victor[0] <= 0){
                    MessageBox.Show("Un triangulo no puede contener valores menores o iguales a cero", "TRIANGULO IMPOSIBLE");
                    
                    break;
                }
                Array.Reverse(victor);
                if(victor[0] < (victor[1] + victor[2])){
                    decimal perimetro = val1 + val2 + val3;
                    decimal semi = perimetro/2;
                    decimal presqrt = (semi * (semi-val1) * (semi-val2) * (semi-val3));
                    double area = Math.Sqrt(Decimal.ToDouble(presqrt));
                    Resultado.Text = "Area: " + area + "\nPerimetro: " + perimetro;
                }
                else{
                    MessageBox.Show("El lado más grande no puede ser más largo que la suma de los demás lados","TRIANGULO IMPOSIBLE");
                }
                break;
                //
                //  Calculo circulo
                //
            case 2:
                Resultado.Text = "Area: " + ((decimal)Math.PI * (val2*val2)) + "\nPerímetro: " + (decimal)Math.PI * (val2*2);
                break;
            default:
                MessageBox.Show("Uhhh, no sé como llegaste aquí... Avisar a Dondé");
                break;
        }
    }
    private void ChangeValueText(ref Object sender, string text1, string text2, string text3){
        Valor1Texto.Text = text1;
        Valor2Texto.Text = text2;
        Valor3Texto.Text = text3;
    }
    private void ChangeValueVisibility(bool vis1, bool vis2, bool vis3){
        Valor1.Visible = vis1;
        Valor1Texto.Visible = vis1;
        Valor2.Visible = vis2;
        Valor2Texto.Visible = vis2;
        Valor3.Visible = vis3;
        Valor3Texto.Visible = vis3;
        
    }
        
}

